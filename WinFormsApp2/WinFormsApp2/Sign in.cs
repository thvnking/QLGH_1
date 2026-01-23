using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Sign_in : Form
    {
        private DataConnection db = new DataConnection();

        public Sign_in()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBoxUser.Text.Trim();
            string pass = textBoxPass.Text.Trim();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo");
                return;
            }

            try
            {
                string query = $@"
                    SELECT t.TenDangNhap, n.HoTen, v.TenVaiTro 
                    FROM TaiKhoan t
                    JOIN NhanVien n ON t.MaNV = n.MaNV
                    JOIN VaiTro v ON n.MaVaiTro = v.MaVaiTro
                    WHERE t.TenDangNhap = N'{user}' AND t.MatKhau = N'{pass}'";

                DataTable dt = db.GetDataTable(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MainMenu main = new MainMenu();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi đăng nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi kết nối");
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}