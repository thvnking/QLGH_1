using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Reporting.WinForms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private DataConnection db = new DataConnection();
        private string currentTable = "";
        private string currentQuery = "";
        private DateTimePicker datePicker = new DateTimePicker();
        private bool isEditing = false;
        private string editingPrimaryValue = "";
        private string lastUndoQuery = "";
        private ReportViewer reportViewer1;

        public Form1()
        {
            InitializeComponent();
            SetupEventHandlers();
            SetupDatePicker();
            InitializeFilterControls();

            dataGridView1.DataError += (s, e) => { e.ThrowException = false; };
            dataGridView2.DataError += (s, e) => { e.ThrowException = false; };
        }

        private void SetupEventHandlers()
        {
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView2.CellClick += DataGridView2_CellClick;
            dataGridView2.KeyDown += DataGridView2_KeyDown;
        }

        private void InitializeFilterControls()
        {
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.AddRange(new string[] { "Đang xử lý", "Đang giao", "Đã giao", "Đã hủy" });
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "Đang xử lý", "Đang giao", "Hoàn thành", "Đã hủy" });
        }

        public void SetFilterVisible(bool hienThi)
        {
            cbbTrangThai.Visible = hienThi;
            cbbMNV.Visible = hienThi;
            btnLoc.Visible = hienThi;
            btnDuyet.Visible = hienThi;
            comboBox1.Visible = hienThi;
            btnPhanCong.Visible = hienThi;
        }


        public void ChiTietVisible(bool hienThi)
        {
            btnChiTiet.Visible = hienThi;
        }

        private string ResolveMaKH(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
            // Kiểm tra nếu input đã là mã số khách hàng
            if (int.TryParse(input, out _)) return input;

            string sql = $"SELECT MaKH FROM KhachHang WHERE TenKH LIKE N'%{input}%' OR SDT LIKE '%{input}%'";
            DataTable dt = db.GetDataTable(sql);

            if (dt.Rows.Count > 0) return dt.Rows[0]["MaKH"].ToString();
            return input;
        }

        public void LoadData(string query)
        {
            currentQuery = query;
            var match = Regex.Match(query, @"FROM\s+\[?(\w+)\]?", RegexOptions.IgnoreCase);
            if (match.Success) currentTable = match.Groups[1].Value;

            DataTable dt = db.GetDataTable(query);
            dataGridView1.DataSource = dt;

            AddActionButtons();
            lblList.Text = currentTable;

            bool isOrderTable = currentTable.Equals("DonHang", StringComparison.OrdinalIgnoreCase);
            SetFilterVisible(isOrderTable);
            if (isOrderTable) LoadNhanVienToComboBox();
            ApplyCustomDesign(dataGridView1);
            ApplyCustomDesign(dataGridView2);

        }

        private void ApplyCustomDesign(DataGridView dgv)
        {
            Color darkBlue = Color.FromArgb(33, 52, 72);
            Color lightBlue = Color.FromArgb(148, 180, 193);

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = darkBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.DefaultCellStyle.SelectionBackColor = lightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = darkBlue;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.RowTemplate.Height = 30;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 240, 245);
            dgv.GridColor = Color.FromArgb(224, 224, 224);
        }


        private void LoadNhanVienToComboBox()
        {
            DataTable dt = db.GetDataTable("SELECT MaNV FROM NhanVien");
            cbbMNV.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cbbMNV.Items.Add(row["MaNV"].ToString());
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable)) return;
            string keyword = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData($"SELECT * FROM [{currentTable}]");
                return;
            }
            List<string> conds = new List<string>();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!(col is DataGridViewButtonColumn))
                    conds.Add($"[{col.Name}] LIKE N'%{keyword}%'");
            }
            string sql = $"SELECT * FROM [{currentTable}] WHERE " + string.Join(" OR ", conds);
            LoadData(sql);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable)) return;

            List<string> filters = new List<string>();
            if (cbbTrangThai.SelectedIndex != -1)
            {
                filters.Add($"[TrangThai] = N'{cbbTrangThai.SelectedItem}'");
            }

            string mnvCol = dataGridView1.Columns.Contains("MaNV_GiaoHang") ? "MaNV_GiaoHang" : (dataGridView1.Columns.Contains("MaNV") ? "MaNV" : "");

            if (cbbMNV.SelectedIndex != -1 && !string.IsNullOrEmpty(mnvCol))
            {
                filters.Add($"[{mnvCol}] = {cbbMNV.SelectedItem}");
            }

            string sql = $"SELECT * FROM [{currentTable}]";
            if (filters.Count > 0) sql += " WHERE " + string.Join(" AND ", filters);

            LoadData(sql);
        }

        private void UpdateRecord(int rowIndex)
        {
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            string pk = dataGridView2.Columns[0].Name;
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewCell cell in row.Cells)
            {
                string colName = cell.OwningColumn.Name;
                if (cell.OwningColumn is DataGridViewButtonColumn || colName == pk) continue;

                string val = cell.Value?.ToString() ?? "";
                if (colName == "MaKH") val = ResolveMaKH(val);

                if (colName.ToLower().Contains("ngay") && DateTime.TryParse(val, out DateTime dt))
                    sb.Append($"[{colName}] = '{dt:yyyy-MM-dd}',");
                else if (int.TryParse(val, out int numVal) && (colName.StartsWith("Ma") || colName.Contains("SoLuong")))
                    sb.Append($"[{colName}] = {numVal},");
                else
                    sb.Append($"[{colName}] = N'{val.Replace("'", "''")}',");
            }
            string sql = $"UPDATE [{currentTable}] SET {sb.ToString().TrimEnd(',')} WHERE [{pk}] = {editingPrimaryValue}";
            if (db.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData(currentQuery);
                dataGridView2.Rows.Clear();
                isEditing = false;
            }
        }

        private void SaveNewRecord(int rowIndex)
        {
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            List<string> cols = new List<string>();
            List<string> vals = new List<string>();

            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.OwningColumn is DataGridViewButtonColumn) continue;

                string colName = cell.OwningColumn.Name;
                string val = cell.Value?.ToString() ?? "";

                if (colName == "MaKH") val = ResolveMaKH(val);

                cols.Add($"[{colName}]");
                if (colName.ToLower().Contains("ngay") && DateTime.TryParse(val, out DateTime dt))
                    vals.Add($"'{dt:yyyy-MM-dd}'");
                else if (int.TryParse(val, out int numVal))
                    vals.Add(numVal.ToString()); // Số
                else
                    vals.Add($"N'{val.Replace("'", "''")}'");
            }

            string sql = $"INSERT INTO [{currentTable}] ({string.Join(",", cols)}) VALUES ({string.Join(",", vals)})";
            if (db.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Thêm mới thành công!");
                LoadData(currentQuery);
                dataGridView2.Rows.Clear();
            }
        }

        private void SetupStatusComboBox(DataGridView dgv)
        {
            for (int i = dgv.Columns.Count - 1; i >= 0; i--)
            {
                if (dgv.Columns[i].Name.ToLower().Contains("trangthai") && !(dgv.Columns[i] is DataGridViewComboBoxColumn))
                {
                    int idx = dgv.Columns[i].Index;
                    string name = dgv.Columns[i].Name;
                    dgv.Columns.RemoveAt(idx);
                    DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn
                    {
                        Name = name,
                        HeaderText = "Trạng thái",
                        FlatStyle = FlatStyle.Flat
                    };
                    combo.Items.AddRange("Đang xử lý", "Đang giao", "Hoàn thành", "Đã hủy");
                    dgv.Columns.Insert(idx, combo);
                }
            }
        }

        private void PrepareEntryGrid()
        {
            dataGridView2.Columns.Clear();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                if (!(col is DataGridViewButtonColumn)) dataGridView2.Columns.Add(col.Name, col.HeaderText);

            SetupStatusComboBox(dataGridView2);
            dataGridView2.Columns.Add(new DataGridViewButtonColumn { Name = "btnSave", HeaderText = "Lưu", Text = "Save", UseColumnTextForButtonValue = false });
            dataGridView2.Columns.Add(new DataGridViewButtonColumn { Name = "btnCancel", HeaderText = "Hủy", Text = "Cancel", UseColumnTextForButtonValue = true });
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            string pk = dataGridView1.Columns.Cast<DataGridViewColumn>().First(c => !(c is DataGridViewButtonColumn)).Name;
            string idValue = dataGridView1.Rows[e.RowIndex].Cells[pk].Value.ToString();

            if (colName == "btnEdit")
            {
                PrepareEntryGrid();
                isEditing = true;
                editingPrimaryValue = idValue;
                int n = dataGridView2.Rows.Add();
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                    if (!(col is DataGridViewButtonColumn))
                        dataGridView2.Rows[n].Cells[col.Name].Value = dataGridView1.Rows[e.RowIndex].Cells[col.Name].Value;
                dataGridView2.Rows[n].Cells["btnSave"].Value = "Update";
            }
            else if (colName == "btnDelete")
            {
                if (MessageBox.Show("Xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    if (db.ExecuteNonQuery($"DELETE FROM [{currentTable}] WHERE [{pk}] = {idValue}")) LoadData(currentQuery);
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView2.Columns[e.ColumnIndex].Name == "btnSave")
            {
                if (isEditing) UpdateRecord(e.RowIndex); else SaveNewRecord(e.RowIndex);
            }
            else if (dataGridView2.Columns[e.ColumnIndex].Name == "btnCancel") dataGridView2.Rows.Clear();

            string colName = dataGridView2.Columns[e.ColumnIndex].Name.ToLower();
            if (colName.Contains("ngay"))
            {
                Rectangle rect = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                datePicker.Size = new Size(rect.Width, rect.Height);
                datePicker.Location = new Point(rect.X, rect.Y);
                datePicker.Visible = true;
            }
            else datePicker.Visible = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0) return;
            isEditing = false;
            PrepareEntryGrid();

            int rowIndex = dataGridView2.Rows.Add();
            string pk = dataGridView2.Columns[0].Name;
            dataGridView2.Rows[rowIndex].Cells[pk].Value = GenerateAutoID(pk);

            if (dataGridView2.Columns.Contains("TrangThai"))
                dataGridView2.Rows[rowIndex].Cells["TrangThai"].Value = "Đang xử lý";

            dataGridView2.Rows[rowIndex].Cells["btnSave"].Value = "Save";
        }

        private string GenerateAutoID(string pkColumn)
        {
            try
            {
                DataTable dt = db.GetDataTable($"SELECT TOP 1 [{pkColumn}] FROM [{currentTable}] ORDER BY [{pkColumn}] DESC");
                if (dt.Rows.Count > 0)
                {
                    int lastID = Convert.ToInt32(dt.Rows[0][0]);
                    return (lastID + 1).ToString();
                }
            }
            catch { }
            return "1";
        }

        private string GenerateAutoIDForPhieuGiao()
        {
            try
            {
                DataTable dt = db.GetDataTable("SELECT MAX(MaPG) FROM PhieuGiao");

                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    int lastID = Convert.ToInt32(dt.Rows[0][0]);
                    return (lastID + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi sinh mã PG: " + ex.Message);
            }
            return "1";
        }

        private void SetupDatePicker()
        {
            datePicker.Visible = false;
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.ValueChanged += (s, e) => { if (dataGridView2.CurrentCell != null) dataGridView2.CurrentCell.Value = datePicker.Value.ToString("yyyy-MM-dd"); };
            dataGridView2.Controls.Add(datePicker);
        }

        private void AddActionButtons()
        {
            if (!dataGridView1.Columns.Contains("btnEdit"))
                dataGridView1.Columns.Add(new DataGridViewButtonColumn { Name = "btnEdit", HeaderText = "Sửa", Text = "Sửa", UseColumnTextForButtonValue = true });
            if (!dataGridView1.Columns.Contains("btnDelete"))
                dataGridView1.Columns.Add(new DataGridViewButtonColumn { Name = "btnDelete", HeaderText = "Xóa", Text = "Xóa", UseColumnTextForButtonValue = true });
        }

        private void Form1_Load(object sender, EventArgs e) { dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; }
        private void DataGridView2_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true; }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblList_Click(object sender, EventArgs e) { }
        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cbbMNV_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable) || comboBox1.SelectedIndex == -1) return;

            string newStatus = comboBox1.SelectedItem.ToString();
            string whereClause = "";
            var match = Regex.Match(currentQuery, @"WHERE\s+(.+)", RegexOptions.IgnoreCase);
            if (match.Success) whereClause = " WHERE " + match.Groups[1].Value;

            if (MessageBox.Show($"Cập nhật tất cả dòng sang '{newStatus}'?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlUpdate = $"UPDATE [{currentTable}] SET [TrangThai] = N'{newStatus}' {whereClause}";
                if (db.ExecuteNonQuery(sqlUpdate))
                {
                    MessageBox.Show("Đã cập nhật thành công!");
                    LoadData(currentQuery);
                }
            }
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            var khuVucMapping = new Dictionary<string, List<int>> {
        { "Ninh Kiều", new List<int> { 8, 9, 10 } },
        { "Cái Răng",  new List<int> { 11, 12, 13 } },
        { "Bình Thủy", new List<int> { 14, 15, 16 } },
        { "Khác",      new List<int> { 17, 18, 19, 20 } }
    };
            DataTable dtDensity = db.GetDataTable(@"
        SELECT nv.MaNV, COUNT(dh.MaDH) as SoDon
        FROM NhanVien nv
        LEFT JOIN DonHang dh ON nv.MaNV = dh.MaNV_GiaoHang AND dh.TrangThai = N'Đang giao'
        GROUP BY nv.MaNV");

            var densityMap = dtDensity.AsEnumerable().ToDictionary(
                r => Convert.ToInt32(r["MaNV"]),
                r => Convert.ToInt32(r["SoDon"])
            );

            if (dataGridView1.Rows.Count == 0) return;
            string pk = dataGridView1.Columns[0].Name;
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[pk].Value == null) continue;
                int maDH = Convert.ToInt32(row.Cells[pk].Value);
                string diaChi = row.Cells["DiaChiChiTiet"].Value?.ToString().ToLower() ?? "";
                List<int> candidateShippers = khuVucMapping["Khác"];
                foreach (var khuVuc in khuVucMapping)
                {
                    if (diaChi.Contains(khuVuc.Key.ToLower()))
                    {
                        candidateShippers = khuVuc.Value;
                        break;
                    }
                }
                int bestShipper = candidateShippers
                    .OrderBy(id => densityMap.ContainsKey(id) ? densityMap[id] : 0)
                    .First();
                string sqlUpdate = $"UPDATE DonHang SET MaNV_GiaoHang = {bestShipper}, TrangThai = N'Đang giao' WHERE [{pk}] = {maDH}";

                if (db.ExecuteNonQuery(sqlUpdate))
                {
                    string maPG = GenerateAutoIDForPhieuGiao();
                    string ngayGiao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string sqlInsertPG = $"INSERT INTO PhieuGiao (MaPG, MaDH, MaNV, NgayGiao) " +
                                         $"VALUES ({maPG}, {maDH}, {bestShipper}, '{ngayGiao}')";

                    db.ExecuteNonQuery(sqlInsertPG);
                    if (densityMap.ContainsKey(bestShipper)) densityMap[bestShipper]++;
                    else densityMap[bestShipper] = 1;

                    count++;
                }
            }

            MessageBox.Show($"Đã phân công thành công {count} đơn hàng và tạo Phiếu Giao tương ứng!", "Thông báo");
            LoadData(currentQuery);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng từ danh sách!", "Thông báo");
                return;
            }

            try
            {
                int maDH = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaDH"].Value);
                string sql = $@"SELECT c.TenHang, c.SoLuong, nv.HoTen as Shipper
                        FROM ChiTietHang c
                        INNER JOIN DonHang d ON c.MaDH = d.MaDH
                        LEFT JOIN NhanVien nv ON d.MaNV_GiaoHang = nv.MaNV
                        WHERE d.MaDH = {maDH}";
                DataTable dt = db.GetDataTable(sql);
                dataGridView2.DataSource = dt;
                lblList.Text = "Chi tiết đơn hàng số: " + maDH;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Đơn hàng này chưa có thông tin sản phẩm chi tiết.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message, "Lỗi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}