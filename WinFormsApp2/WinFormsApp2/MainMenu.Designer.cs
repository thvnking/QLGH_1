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
            panelMenu = new Panel();
            buttonDC = new Button();
            buttonCT = new Button();
            buttonDX = new Button();
            buttonTC = new Button();
            buttonKH = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            label1 = new Label();
            buttonNV = new Button();
            buttonDH = new Button();
            panelHeader = new Panel();
            buttonSquare = new Button();
            buttonMi = new Button();
            buttonClose = new Button();
            labelTitle = new Label();
            panelBody = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 52, 72);
            panelMenu.Controls.Add(buttonDC);
            panelMenu.Controls.Add(buttonCT);
            panelMenu.Controls.Add(buttonDX);
            panelMenu.Controls.Add(buttonTC);
            panelMenu.Controls.Add(buttonKH);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(buttonNV);
            panelMenu.Controls.Add(buttonDH);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 704);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // buttonDC
            // 
            buttonDC.BackColor = Color.FromArgb(33, 52, 72);
            buttonDC.FlatStyle = FlatStyle.Flat;
            buttonDC.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic);
            buttonDC.ForeColor = Color.FromArgb(148, 180, 193);
            buttonDC.Location = new Point(0, 280);
            buttonDC.Margin = new Padding(0);
            buttonDC.Name = "buttonDC";
            buttonDC.Size = new Size(220, 60);
            buttonDC.TabIndex = 9;
            buttonDC.Text = "Địa Chỉ";
            buttonDC.UseVisualStyleBackColor = false;
            buttonDC.Click += buttonDC_Click;
            // 
            // buttonCT
            // 
            buttonCT.BackColor = Color.FromArgb(33, 52, 72);
            buttonCT.FlatStyle = FlatStyle.Flat;
            buttonCT.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic);
            buttonCT.ForeColor = Color.FromArgb(148, 180, 193);
            buttonCT.Location = new Point(0, 220);
            buttonCT.Margin = new Padding(0);
            buttonCT.Name = "buttonCT";
            buttonCT.Size = new Size(220, 60);
            buttonCT.TabIndex = 8;
            buttonCT.Text = "Chi Tiết Đơn";
            buttonCT.UseVisualStyleBackColor = false;
            buttonCT.Click += buttonPG_Click;
            // 
            // buttonDX
            // 
            buttonDX.BackColor = Color.FromArgb(33, 52, 72);
            buttonDX.Dock = DockStyle.Bottom;
            buttonDX.FlatStyle = FlatStyle.Flat;
            buttonDX.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonDX.ForeColor = Color.FromArgb(148, 180, 193);
            buttonDX.Location = new Point(0, 670);
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
            buttonTC.BackColor = Color.FromArgb(33, 52, 72);
            buttonTC.FlatStyle = FlatStyle.Flat;
            buttonTC.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic);
            buttonTC.ForeColor = Color.FromArgb(148, 180, 193);
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
            buttonKH.BackColor = Color.FromArgb(33, 52, 72);
            buttonKH.FlatStyle = FlatStyle.Flat;
            buttonKH.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic);
            buttonKH.ForeColor = Color.FromArgb(148, 180, 193);
            buttonKH.Location = new Point(0, 340);
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
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("ROG Fonts", 27.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(148, 180, 193);
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(215, 44);
            label2.TabIndex = 6;
            label2.Text = "DEF4ST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("ROG Fonts", 27.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 180, 193);
            label1.Location = new Point(2, 26);
            label1.Name = "label1";
            label1.Size = new Size(215, 44);
            label1.TabIndex = 5;
            label1.Text = "DEF4ST";
            // 
            // buttonNV
            // 
            buttonNV.BackColor = Color.FromArgb(33, 52, 72);
            buttonNV.FlatStyle = FlatStyle.Flat;
            buttonNV.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic);
            buttonNV.ForeColor = Color.FromArgb(148, 180, 193);
            buttonNV.Location = new Point(0, 400);
            buttonNV.Margin = new Padding(0);
            buttonNV.Name = "buttonNV";
            buttonNV.Size = new Size(220, 60);
            buttonNV.TabIndex = 4;
            buttonNV.Text = "Nhân Viên";
            buttonNV.UseVisualStyleBackColor = false;
            buttonNV.Click += buttonNV_Click;
            // 
            // buttonDH
            // 
            buttonDH.BackColor = Color.FromArgb(33, 52, 72);
            buttonDH.FlatStyle = FlatStyle.Flat;
            buttonDH.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic);
            buttonDH.ForeColor = Color.FromArgb(148, 180, 193);
            buttonDH.Location = new Point(0, 160);
            buttonDH.Margin = new Padding(0);
            buttonDH.Name = "buttonDH";
            buttonDH.Size = new Size(220, 60);
            buttonDH.TabIndex = 2;
            buttonDH.Text = "Đơn Hàng";
            buttonDH.UseVisualStyleBackColor = false;
            buttonDH.Click += buttonDH_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(56, 65, 157);
            panelHeader.Controls.Add(buttonSquare);
            panelHeader.Controls.Add(buttonMi);
            panelHeader.Controls.Add(buttonClose);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(961, 100);
            panelHeader.TabIndex = 1;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // buttonSquare
            // 
            buttonSquare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSquare.BackColor = Color.FromArgb(33, 52, 72);
            buttonSquare.FlatAppearance.BorderSize = 0;
            buttonSquare.FlatStyle = FlatStyle.Flat;
            buttonSquare.Font = new Font("ROG Fonts", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSquare.ForeColor = Color.FromArgb(148, 180, 193);
            buttonSquare.Location = new Point(857, -12);
            buttonSquare.Margin = new Padding(0);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(52, 37);
            buttonSquare.TabIndex = 10;
            buttonSquare.Text = "□";
            buttonSquare.UseVisualStyleBackColor = false;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonMi
            // 
            buttonMi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMi.BackColor = Color.FromArgb(33, 52, 72);
            buttonMi.FlatAppearance.BorderSize = 0;
            buttonMi.FlatStyle = FlatStyle.Flat;
            buttonMi.Font = new Font("ROG Fonts", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMi.ForeColor = Color.FromArgb(148, 180, 193);
            buttonMi.Location = new Point(805, -9);
            buttonMi.Margin = new Padding(0);
            buttonMi.Name = "buttonMi";
            buttonMi.Size = new Size(52, 33);
            buttonMi.TabIndex = 9;
            buttonMi.Text = "-";
            buttonMi.UseVisualStyleBackColor = false;
            buttonMi.Click += buttonMi_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("ROG Fonts", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.ForeColor = Color.FromArgb(33, 52, 72);
            buttonClose.Location = new Point(909, -7);
            buttonClose.Margin = new Padding(0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(52, 31);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(33, 52, 72);
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(148, 180, 193);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(961, 100);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "TRANG CHỦ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            panelBody.AutoSize = true;
            panelBody.BackColor = SystemColors.ActiveBorder;
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(220, 100);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(961, 604);
            panelBody.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 14, 58);
            ClientSize = new Size(1181, 704);
            ControlBox = false;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1000, 650);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button buttonDX;
        private Button buttonTC;
        private Button buttonKH;
        private Button buttonNV;
        private Button buttonDH;
        private Panel panelLogo;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelBody;
        private Label label1;
        private Button buttonSquare;
        private Button buttonMi;
        private Button buttonClose;
        private Button buttonCT;
        private Label label2;
        private Button buttonDC;
    }
}
