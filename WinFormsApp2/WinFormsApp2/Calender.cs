using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Calender : Form
    {
        DataConnection db = new DataConnection();

        public Calender()
        {
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadLawyers();
            LoadAppointments();
        }

        // ================= LOAD DATA =================

        public void LoadData(string sql)
        {
            try
            {
                DataConnection db = new DataConnection();

                DataTable dt = db.GetDataTable(sql);

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void LoadAppointments()
        {
            string sql = @"
            SELECT 
                a.appointment_id AS MaLichHen,
                c.full_name AS KhachHang,
                l.full_name AS LuatSu,
                a.location AS DiaDiem,
                a.appointment_time AS ThoiGian,
                a.note AS GhiChu,
                a.status AS TrangThai
            FROM appointments a
            LEFT JOIN clients c ON a.client_id = c.client_id
            LEFT JOIN lawyers l ON a.lawyer_id = l.lawyer_id
            ORDER BY a.appointment_id DESC";

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.GetDataTable(sql);

            AddButtons();
        }

        private void LoadClients()
        {
            string sql = "SELECT client_id, full_name FROM clients";

            DataTable dt = db.GetDataTable(sql);

            cbBKhachHang.DataSource = dt;
            cbBKhachHang.DisplayMember = "full_name";
            cbBKhachHang.ValueMember = "client_id";
        }

        private void LoadLawyers()
        {
            string sql = "SELECT lawyer_id, full_name FROM lawyers";

            DataTable dt = db.GetDataTable(sql);

            cbBLuatSu.DataSource = dt;
            cbBLuatSu.DisplayMember = "full_name";
            cbBLuatSu.ValueMember = "lawyer_id";
        }

        // ================= ADD BUTTON =================

        private void AddButtons()
        {
            if (!dataGridView1.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.Name = "btnEdit";
                edit.HeaderText = "Sửa";
                edit.Text = "Sửa";
                edit.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(edit);
            }

            if (!dataGridView1.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                delete.Name = "btnDelete";
                delete.HeaderText = "Xóa";
                delete.Text = "Xóa";
                delete.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(delete);
            }
        }

        // ================= CLICK ROW =================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtBMaLichHen.Text = row.Cells["MaLichHen"].Value?.ToString();
            cbBKhachHang.Text = row.Cells["KhachHang"].Value?.ToString();
            cbBLuatSu.Text = row.Cells["LuatSu"].Value?.ToString();
            txtBDiaDiem.Text = row.Cells["DiaDiem"].Value?.ToString();
            txtbThoiGian.Text = row.Cells["ThoiGian"].Value?.ToString();
            txtBGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            cbBTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();

            string column = dataGridView1.Columns[e.ColumnIndex].Name;

            string id = row.Cells["MaLichHen"].Value?.ToString();

            if (column == "btnDelete")
            {
                if (MessageBox.Show("Xóa lịch hẹn ?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM appointments WHERE appointment_id={id}";

                    if (db.ExecuteNonQuery(sql))
                    {
                        MessageBox.Show("Đã xóa");
                        LoadAppointments();
                    }
                }
            }

            if (column == "btnEdit")
            {
                string sql = $@"
                UPDATE appointments SET
                client_id = {cbBKhachHang.SelectedValue},
                lawyer_id = {cbBLuatSu.SelectedValue},
                location = N'{txtBDiaDiem.Text}',
                appointment_time = '{txtbThoiGian.Text}',
                note = N'{txtBGhiChu.Text}',
                status = N'{cbBTrangThai.Text}'
                WHERE appointment_id = {id}";

                if (db.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadAppointments();
                }
            }
        }

        // ================= ADD APPOINTMENT =================

        private void buttonTLH_Click(object sender, EventArgs e)
        {
            string location = txtBDiaDiem.Text.Trim();
            string time = txtbThoiGian.Text.Trim();
            string note = txtBGhiChu.Text.Trim();
            string status = cbBTrangThai.Text;

            if (location == "")
            {
                MessageBox.Show("Nhập địa điểm");
                return;
            }

            string sql = $@"
            INSERT INTO appointments
            (client_id,lawyer_id,location,appointment_time,note,status,created_at)
            VALUES
            (
            {cbBKhachHang.SelectedValue},
            {cbBLuatSu.SelectedValue},
            N'{location}',
            '{time}',
            N'{note}',
            N'{status}',
            GETDATE()
            )";

            if (db.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Thêm lịch hẹn thành công");

                LoadAppointments();

                txtBDiaDiem.Clear();
                txtbThoiGian.Clear();
                txtBGhiChu.Clear();
            }
        }

        // ================= SEARCH =================

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtBMaLichHen.Text.Trim();

            if (keyword == "")
            {
                LoadAppointments();
                return;
            }

            string sql = $@"
            SELECT 
                a.appointment_id AS MaLichHen,
                c.full_name AS KhachHang,
                l.full_name AS LuatSu,
                a.location AS DiaDiem,
                a.appointment_time AS ThoiGian,
                a.note AS GhiChu,
                a.status AS TrangThai
            FROM appointments a
            LEFT JOIN clients c ON a.client_id = c.client_id
            LEFT JOIN lawyers l ON a.lawyer_id = l.lawyer_id
            WHERE a.appointment_id LIKE '%{keyword}%'";

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.GetDataTable(sql);

            AddButtons();
        }
    }
}