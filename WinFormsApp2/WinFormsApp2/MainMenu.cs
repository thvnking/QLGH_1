using System.Security.Cryptography;

namespace WinFormsApp2
{
    public partial class MainMenu : Form
    {
        private Form activeForm = null;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTC_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            labelTitle.Text = "TRANG CHỦ";
        }
        private void buttonDH_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.LoadData("SELECT * FROM DonHang");
            labelTitle.Text = "QUẢN LÝ ĐƠN HÀNG";
        }
        private void buttonKH_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.SetFilterVisible(false);
            frm.ChiTietVisible(false);
            frm.LoadData("SELECT * FROM KhachHang");
            labelTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
        }
        private void buttonNV_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.SetFilterVisible(false);
            frm.ChiTietVisible(false);
            frm.LoadData("SELECT * FROM NhanVien");
            labelTitle.Text = "QUẢN LÝ NHÂN VIÊN";
        }
        private void buttonDX_Click_1(object sender, EventArgs e)
        {
            Sign_in login = new Sign_in();
            login.Show();

            this.Close();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonPG_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.SetFilterVisible(false);
            frm.ChiTietVisible(false);
            frm.LoadData("SELECT * FROM ChiTietHang");
            labelTitle.Text = "QUẢN LÝ Chi Tiết Hàng";
        }

        private void buttonDC_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.SetFilterVisible(false);
            frm.ChiTietVisible(false);
            frm.LoadData("SELECT * FROM DiaChi");
            labelTitle.Text = "QUẢN LÝ Địa Chỉ";
        }
    }
}
