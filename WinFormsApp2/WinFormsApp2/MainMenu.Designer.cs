namespace WinFormsApp2
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelMenu = new Panel();
            buttonTK = new Button();
            buttonLH = new Button();
            buttonLS = new Button();
            buttonDX = new Button();
            buttonTC = new Button();
            buttonKH = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            buttonHS = new Button();
            panelBody = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(29, 60, 107);
            panelMenu.BorderStyle = BorderStyle.Fixed3D;
            panelMenu.Controls.Add(buttonTK);
            panelMenu.Controls.Add(buttonLH);
            panelMenu.Controls.Add(buttonLS);
            panelMenu.Controls.Add(buttonDX);
            panelMenu.Controls.Add(buttonTC);
            panelMenu.Controls.Add(buttonKH);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(buttonHS);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.FromArgb(177, 148, 95);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(224, 704);
            panelMenu.TabIndex = 0;
            // 
            // buttonTK
            // 
            buttonTK.BackColor = Color.FromArgb(29, 60, 107);
            buttonTK.Dock = DockStyle.Bottom;
            buttonTK.FlatStyle = FlatStyle.Flat;
            buttonTK.Font = new Font("Times New Roman", 15.75F);
            buttonTK.ForeColor = Color.FromArgb(177, 148, 95);
            buttonTK.Location = new Point(0, 632);
            buttonTK.Margin = new Padding(0);
            buttonTK.Name = "buttonTK";
            buttonTK.Size = new Size(220, 34);
            buttonTK.TabIndex = 10;
            buttonTK.Text = "Tài Khoản";
            buttonTK.UseVisualStyleBackColor = false;
            buttonTK.Click += buttonTK_Click;
            // 
            // buttonLH
            // 
            buttonLH.BackColor = Color.FromArgb(29, 60, 107);
            buttonLH.FlatStyle = FlatStyle.Flat;
            buttonLH.Font = new Font("Times New Roman", 20.25F);
            buttonLH.ForeColor = Color.FromArgb(177, 148, 95);
            buttonLH.Location = new Point(0, 340);
            buttonLH.Margin = new Padding(0);
            buttonLH.Name = "buttonLH";
            buttonLH.Size = new Size(220, 60);
            buttonLH.TabIndex = 9;
            buttonLH.Text = "Lịch Hẹn";
            buttonLH.UseVisualStyleBackColor = false;
            // 
            // buttonLS
            // 
            buttonLS.BackColor = Color.FromArgb(29, 60, 107);
            buttonLS.FlatStyle = FlatStyle.Flat;
            buttonLS.Font = new Font("Times New Roman", 20.25F);
            buttonLS.ForeColor = Color.FromArgb(177, 148, 95);
            buttonLS.Location = new Point(0, 220);
            buttonLS.Margin = new Padding(0);
            buttonLS.Name = "buttonLS";
            buttonLS.Size = new Size(220, 60);
            buttonLS.TabIndex = 8;
            buttonLS.Text = "Luật Sư";
            buttonLS.UseVisualStyleBackColor = false;
            buttonLS.Click += buttonLS_Click;
            // 
            // buttonDX
            // 
            buttonDX.BackColor = Color.FromArgb(29, 60, 107);
            buttonDX.Dock = DockStyle.Bottom;
            buttonDX.FlatStyle = FlatStyle.Flat;
            buttonDX.Font = new Font("Times New Roman", 15.75F);
            buttonDX.ForeColor = Color.FromArgb(177, 148, 95);
            buttonDX.Location = new Point(0, 666);
            buttonDX.Margin = new Padding(0);
            buttonDX.Name = "buttonDX";
            buttonDX.Size = new Size(220, 34);
            buttonDX.TabIndex = 7;
            buttonDX.Text = "Đăng Xuất";
            buttonDX.UseVisualStyleBackColor = false;
            buttonDX.Click += buttonDX_Click_1;
            // 
            // buttonTC
            // 
            buttonTC.BackColor = Color.FromArgb(29, 60, 107);
            buttonTC.FlatStyle = FlatStyle.Flat;
            buttonTC.Font = new Font("Times New Roman", 20.25F);
            buttonTC.ForeColor = Color.FromArgb(177, 148, 95);
            buttonTC.Location = new Point(0, 100);
            buttonTC.Margin = new Padding(0);
            buttonTC.Name = "buttonTC";
            buttonTC.Size = new Size(220, 60);
            buttonTC.TabIndex = 6;
            buttonTC.Text = "Trang Chủ";
            buttonTC.UseVisualStyleBackColor = false;
            buttonTC.Click += buttonTC_Click;
            // 
            // buttonKH
            // 
            buttonKH.BackColor = Color.FromArgb(29, 60, 107);
            buttonKH.FlatStyle = FlatStyle.Flat;
            buttonKH.Font = new Font("Times New Roman", 20.25F);
            buttonKH.ForeColor = Color.FromArgb(177, 148, 95);
            buttonKH.Location = new Point(0, 280);
            buttonKH.Margin = new Padding(0);
            buttonKH.Name = "buttonKH";
            buttonKH.Size = new Size(220, 60);
            buttonKH.TabIndex = 5;
            buttonKH.Text = "Khách Hàng";
            buttonKH.UseVisualStyleBackColor = false;
            buttonKH.Click += buttonKH_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(33, 52, 72);
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(label1);
            panelLogo.ForeColor = Color.FromArgb(177, 148, 95);
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("SimSun-ExtB", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 100);
            label2.TabIndex = 6;
            label2.Text = "AlberlaW";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 27.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 180, 193);
            label1.Location = new Point(2, 26);
            label1.Name = "label1";
            label1.Size = new Size(168, 42);
            label1.TabIndex = 5;
            label1.Text = "DEF4ST";
            // 
            // buttonHS
            // 
            buttonHS.BackColor = Color.FromArgb(29, 60, 107);
            buttonHS.FlatStyle = FlatStyle.Flat;
            buttonHS.Font = new Font("Times New Roman", 20.25F);
            buttonHS.ForeColor = Color.FromArgb(177, 148, 95);
            buttonHS.Location = new Point(0, 160);
            buttonHS.Margin = new Padding(0);
            buttonHS.Name = "buttonHS";
            buttonHS.Size = new Size(220, 60);
            buttonHS.TabIndex = 2;
            buttonHS.Text = "Hồ Sơ";
            buttonHS.UseVisualStyleBackColor = false;
            buttonHS.Click += buttonHS_Click;
            // 
            // panelBody
            // 
            panelBody.AutoSize = true;
            panelBody.BackColor = Color.FromArgb(29, 60, 107);
            panelBody.Controls.Add(pictureBox1);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(224, 0);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(957, 704);
            panelBody.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(957, 704);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 14, 58);
            ClientSize = new Size(1181, 704);
            Controls.Add(panelBody);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1000, 650);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel panelMenu;
        private Button buttonDX;
        private Button buttonTC;
        private Button buttonKH;
        private Button buttonHS;
        private Panel panelLogo;
        private Panel panelBody;
        private Label label1;
        private Button buttonLS;
        private Label label2;
        private Button buttonLH;
        private Button buttonTK;
        private PictureBox pictureBox1;
    }
}
