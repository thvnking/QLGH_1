using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class DataView : Form
    {
        private DataConnection db = new DataConnection();
        private string currentTable = "";
        private string currentQuery = "";
        private DateTimePicker datePicker = new DateTimePicker();
        private bool isEditing = false;
        private string editingPrimaryValue = "";
        private string lastUndoQuery = "";
        public DataView()
        {
            InitializeComponent();
            SetupEventHandlers();
            InitializeFilterControls();

            dataGridView1.DataError += (s, e) => { e.ThrowException = false; };
            dataGridView2.DataError += (s, e) => { e.ThrowException = false; };
        }

        private void DataView_Load(object sender, EventArgs e)
        {

        }
        private void SetupEventHandlers()
        {
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView2.CellClick += DataGridView2_CellClick;
            dataGridView2.KeyDown += DataGridView2_KeyDown;
        }

        private void InitializeFilterControls()
        {
        }

        public void SetFilterVisible(bool hienThi)
        {
        }

        private string ResolveMaKH(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
