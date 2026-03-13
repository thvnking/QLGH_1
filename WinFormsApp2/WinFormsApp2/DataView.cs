using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class DataView : Form
    {
        DataConnection db = new DataConnection();

        public DataView()
        {
            InitializeComponent();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView2.CellClick += DataGridView2_CellClick;
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            LoadContracts();
        }

        // ================= LOAD CONTRACT =================

        public void LoadData(string query)
        {
            currentQuery = query;
            var match = Regex.Match(query, @"FROM\s+\[?(\w+)\]?", RegexOptions.IgnoreCase);
            if (match.Success) currentTable = match.Groups[1].Value;

            DataTable dt = db.GetDataTable(query);
            dataGridView1.DataSource = dt;

        }

        private void LoadContracts()
        {
            try
            {
                string sql = @"
                SELECT 
                    c.contract_id AS MaHopDong,
                    c.contract_title AS TenHopDong,
                    cl.full_name AS TenKhachHang,
                    l.full_name AS TenLuatSu,
                    c.contract_value AS GiaTri,
                    c.start_date AS NgayBatDau,
                    c.end_date AS NgayKetThuc,
                    c.status AS TrangThai
                FROM contracts c
                LEFT JOIN clients cl ON c.client_id = cl.client_id
                LEFT JOIN lawyers l ON c.lawyer_id = l.lawyer_id
                ORDER BY c.contract_id DESC";

                DataTable dt = db.GetDataTable(sql);

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;

                AddActionButtons();

                ApplyDesign(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        // ================= LOAD FILE =================

        private void LoadContractFiles(string contractID)
        {
            try
            {
                string sql = $@"
                SELECT
                    file_id AS MaFile,
                    file_name AS TenFile,
                    file_path AS DuongDan,
                    uploaded_at AS NgayUpload
                FROM contract_files
                WHERE contract_id = {contractID}";

                DataTable dt = db.GetDataTable(sql);

                dataGridView2.Columns.Clear();
                dataGridView2.DataSource = dt;

                if (!dataGridView2.Columns.Contains("btnOpen"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "btnOpen";
                    btn.HeaderText = "Mở File";
                    btn.Text = "Open";
                    btn.UseColumnTextForButtonValue = true;

                    dataGridView2.Columns.Add(btn);
                }

                ApplyDesign(dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load file: " + ex.Message);
            }
        }

        // ================= SELECT CONTRACT =================

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DataGridViewRow row = dataGridView1.CurrentRow;

            textBoxMHD.Text = row.Cells["MaHopDong"].Value?.ToString();
            textBoxTHD.Text = row.Cells["TenHopDong"].Value?.ToString();
            textBoxTKH.Text = row.Cells["TenKhachHang"].Value?.ToString();
            textBoxTLS.Text = row.Cells["TenLuatSu"].Value?.ToString();

            string id = row.Cells["MaHopDong"].Value?.ToString();

            if (!string.IsNullOrEmpty(id))
                LoadContractFiles(id);
        }

        // ================= ADD CONTRACT =================

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenHD = textBoxTHD.Text.Trim();
                string tenKH = textBoxTKH.Text.Trim();
                string tenLS = textBoxTLS.Text.Trim();

                if (string.IsNullOrEmpty(tenHD))
                {
                    MessageBox.Show("Vui lòng nhập tên hợp đồng");
                    return;
                }

                string sql = $@"
                INSERT INTO contracts(contract_title,client_id,lawyer_id,status,created_at)
                VALUES(
                N'{tenHD}',
                (SELECT TOP 1 client_id FROM clients WHERE full_name=N'{tenKH}'),
                (SELECT TOP 1 lawyer_id FROM lawyers WHERE full_name=N'{tenLS}'),
                'active',
                GETDATE())";

                if (db.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Thêm hợp đồng thành công");

                    LoadContracts();

                    textBoxTHD.Clear();
                    textBoxTKH.Clear();
                    textBoxTLS.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hợp đồng: " + ex.Message);
            }
        }

        // ================= EDIT / DELETE =================

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string column = dataGridView1.Columns[e.ColumnIndex].Name;
            string id = dataGridView1.Rows[e.RowIndex].Cells["MaHopDong"].Value?.ToString();

            if (string.IsNullOrEmpty(id)) return;

            try
            {
                if (column == "btnDelete")
                {
                    if (MessageBox.Show("Bạn muốn xóa hợp đồng ?", "Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string sql = $"DELETE FROM contracts WHERE contract_id={id}";

                        if (db.ExecuteNonQuery(sql))
                        {
                            MessageBox.Show("Đã xóa hợp đồng");
                            LoadContracts();
                        }
                    }
                }

                if (column == "btnEdit")
                {
                    string title = textBoxTHD.Text.Trim();

                    if (title == "")
                    {
                        MessageBox.Show("Nhập tên hợp đồng");
                        return;
                    }

                    string sql = $@"
                    UPDATE contracts
                    SET contract_title=N'{title}'
                    WHERE contract_id={id}";

                    if (db.ExecuteNonQuery(sql))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        LoadContracts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý: " + ex.Message);
            }
        }

        // ================= OPEN FILE =================

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView2.Columns[e.ColumnIndex].Name == "btnOpen")
            {
                string path = dataGridView2.Rows[e.RowIndex].Cells["DuongDan"].Value?.ToString();

                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                    {
                        System.Diagnostics.Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("File không tồn tại");
                    }
                }
            }
        }

        // ================= SEARCH =================

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = textBox1.Text.Trim();

                if (keyword == "")
                {
                    LoadContracts();
                    return;
                }

                string sql = $@"
                SELECT 
                    c.contract_id AS MaHopDong,
                    c.contract_title AS TenHopDong,
                    cl.full_name AS TenKhachHang,
                    l.full_name AS TenLuatSu
                FROM contracts c
                LEFT JOIN clients cl ON c.client_id = cl.client_id
                LEFT JOIN lawyers l ON c.lawyer_id = l.lawyer_id
                WHERE c.contract_title LIKE N'%{keyword}%'";

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = db.GetDataTable(sql);

                AddActionButtons();
                ApplyDesign(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // ================= BUTTON COLUMN =================

        private void AddActionButtons()
        {
            if (!dataGridView1.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.Name = "btnEdit";
                edit.HeaderText = "Sửa";
                edit.Text = "Edit";
                edit.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(edit);
            }

            if (!dataGridView1.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                delete.Name = "btnDelete";
                delete.HeaderText = "Xóa";
                delete.Text = "Delete";
                delete.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(delete);
            }
        }

        // ================= DESIGN =================

        private void ApplyDesign(DataGridView dgv)
        {
            Color darkBlue = Color.FromArgb(33, 52, 72);
            Color lightBlue = Color.FromArgb(148, 180, 193);

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = darkBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.SelectionBackColor = lightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = darkBlue;

            dgv.RowTemplate.Height = 30;
        }
    }
}