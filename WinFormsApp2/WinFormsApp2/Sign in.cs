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
        SELECT u.user_id, u.username, r.role_name
        FROM users u
        JOIN roles r ON u.role_id = r.role_id
        WHERE u.username = '{user}' 
        AND u.password_hash = '{pass}'
        AND u.status = 1";

                DataTable dt = db.GetDataTable(query);

                if (dt.Rows.Count > 0)
                {
                    MainMenu main = new MainMenu();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}