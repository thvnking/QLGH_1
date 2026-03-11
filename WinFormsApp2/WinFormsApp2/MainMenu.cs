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

        private void buttonTC_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }
        private void buttonHS_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.LoadData("SELECT * FROM contracts");
        }
        private void buttonKH_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.LoadData("SELECT * FROM clients");
        }
        private void buttonLS_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.LoadData("SELECT * FROM lawyers");
        }
        private void buttonDX_Click_1(object sender, EventArgs e)
        {
            Sign_in login = new Sign_in();
            login.Show();
            this.Close();
        }
        private void buttonPG_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            openChildForm(frm);
            frm.LoadData("SELECT * FROM ChiTietHang");
        }
        private void buttonTK_Click(object sender, EventArgs e)
        {
            DataView frm = new DataView();
            openChildForm(frm);
            frm.LoadData("SELECT * FROM users");
        }
    }
}
