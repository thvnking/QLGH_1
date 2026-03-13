namespace WinFormsApp2
{
    partial class Calender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            lblList = new Label();
            btnTim = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            cbBLS = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            cbBTrangThai = new ComboBox();
            label1 = new Label();
            buttonTLH = new Button();
            txtBGhiChu = new TextBox();
            txtbThoiGian = new TextBox();
            txtBDiaDiem = new TextBox();
            cbBLuatSu = new ComboBox();
            cbBKhachHang = new ComboBox();
            txtBMaLichHen = new TextBox();
            labeGC = new Label();
            labelTKH = new Label();
            labelTLS = new Label();
            labelTG = new Label();
            labelDD = new Label();
            labelMLH = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 52, 72);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblList);
            panel1.Controls.Add(btnTim);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 100);
            panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 14.25F);
            textBox1.Location = new Point(846, 23);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 29);
            textBox1.TabIndex = 5;
            // 
            // lblList
            // 
            lblList.Dock = DockStyle.Left;
            lblList.Font = new Font("SimSun-ExtB", 36F);
            lblList.ForeColor = Color.FromArgb(177, 148, 95);
            lblList.Location = new Point(0, 0);
            lblList.Name = "lblList";
            lblList.Size = new Size(326, 100);
            lblList.TabIndex = 0;
            lblList.Text = "Appointments";
            lblList.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.BackColor = Color.FromArgb(29, 60, 107);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Times New Roman", 14.25F);
            btnTim.ForeColor = Color.FromArgb(177, 148, 95);
            btnTim.Location = new Point(1051, 22);
            btnTim.Margin = new Padding(0);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 60, 107);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30);
            panel2.Size = new Size(723, 386);
            panel2.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(30, 69);
            panel6.Name = "panel6";
            panel6.Size = new Size(663, 287);
            panel6.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(663, 287);
            dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbBLS);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(30, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(663, 39);
            panel5.TabIndex = 2;
            // 
            // cbBLS
            // 
            cbBLS.FormattingEnabled = true;
            cbBLS.Location = new Point(462, 7);
            cbBLS.Name = "cbBLS";
            cbBLS.Size = new Size(198, 23);
            cbBLS.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.ForeColor = Color.FromArgb(177, 148, 95);
            label2.Location = new Point(387, 9);
            label2.Margin = new Padding(3, 30, 3, 30);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 24;
            label2.Text = "Luật Sư";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 60, 107);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(723, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 386);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbBTrangThai);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(buttonTLH);
            panel4.Controls.Add(txtBGhiChu);
            panel4.Controls.Add(txtbThoiGian);
            panel4.Controls.Add(txtBDiaDiem);
            panel4.Controls.Add(cbBLuatSu);
            panel4.Controls.Add(cbBKhachHang);
            panel4.Controls.Add(txtBMaLichHen);
            panel4.Controls.Add(labeGC);
            panel4.Controls.Add(labelTKH);
            panel4.Controls.Add(labelTLS);
            panel4.Controls.Add(labelTG);
            panel4.Controls.Add(labelDD);
            panel4.Controls.Add(labelMLH);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 386);
            panel4.TabIndex = 0;
            // 
            // cbBTrangThai
            // 
            cbBTrangThai.FormattingEnabled = true;
            cbBTrangThai.Location = new Point(143, 333);
            cbBTrangThai.Name = "cbBTrangThai";
            cbBTrangThai.Size = new Size(277, 23);
            cbBTrangThai.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.ForeColor = Color.FromArgb(177, 148, 95);
            label1.Location = new Point(30, 335);
            label1.Margin = new Padding(3, 30, 3, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 22;
            label1.Text = "Trạng Thái";
            // 
            // buttonTLH
            // 
            buttonTLH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTLH.BackColor = Color.FromArgb(29, 60, 107);
            buttonTLH.FlatStyle = FlatStyle.Flat;
            buttonTLH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTLH.ForeColor = Color.FromArgb(177, 148, 95);
            buttonTLH.Location = new Point(291, 24);
            buttonTLH.Margin = new Padding(0);
            buttonTLH.Name = "buttonTLH";
            buttonTLH.Size = new Size(129, 33);
            buttonTLH.TabIndex = 6;
            buttonTLH.Text = "Tạo Lịch Hẹn";
            buttonTLH.UseVisualStyleBackColor = false;
            buttonTLH.Click += buttonTLH_Click;
            // 
            // txtBGhiChu
            // 
            txtBGhiChu.Location = new Point(143, 231);
            txtBGhiChu.Multiline = true;
            txtBGhiChu.Name = "txtBGhiChu";
            txtBGhiChu.Size = new Size(277, 89);
            txtBGhiChu.TabIndex = 21;
            // 
            // txtbThoiGian
            // 
            txtbThoiGian.Location = new Point(143, 190);
            txtbThoiGian.Name = "txtbThoiGian";
            txtbThoiGian.Size = new Size(277, 23);
            txtbThoiGian.TabIndex = 20;
            // 
            // txtBDiaDiem
            // 
            txtBDiaDiem.Location = new Point(143, 148);
            txtBDiaDiem.Name = "txtBDiaDiem";
            txtBDiaDiem.Size = new Size(277, 23);
            txtBDiaDiem.TabIndex = 19;
            // 
            // cbBLuatSu
            // 
            cbBLuatSu.FormattingEnabled = true;
            cbBLuatSu.Location = new Point(143, 106);
            cbBLuatSu.Name = "cbBLuatSu";
            cbBLuatSu.Size = new Size(277, 23);
            cbBLuatSu.TabIndex = 18;
            // 
            // cbBKhachHang
            // 
            cbBKhachHang.FormattingEnabled = true;
            cbBKhachHang.Location = new Point(143, 67);
            cbBKhachHang.Name = "cbBKhachHang";
            cbBKhachHang.Size = new Size(277, 23);
            cbBKhachHang.TabIndex = 17;
            // 
            // txtBMaLichHen
            // 
            txtBMaLichHen.Location = new Point(143, 25);
            txtBMaLichHen.Name = "txtBMaLichHen";
            txtBMaLichHen.Size = new Size(140, 23);
            txtBMaLichHen.TabIndex = 16;
            // 
            // labeGC
            // 
            labeGC.AutoSize = true;
            labeGC.Font = new Font("Times New Roman", 14.25F);
            labeGC.ForeColor = Color.FromArgb(177, 148, 95);
            labeGC.Location = new Point(30, 231);
            labeGC.Margin = new Padding(3, 30, 3, 30);
            labeGC.Name = "labeGC";
            labeGC.Size = new Size(73, 21);
            labeGC.TabIndex = 15;
            labeGC.Text = "Ghi Chú";
            // 
            // labelTKH
            // 
            labelTKH.AutoSize = true;
            labelTKH.Font = new Font("Times New Roman", 14.25F);
            labelTKH.ForeColor = Color.FromArgb(177, 148, 95);
            labelTKH.Location = new Point(30, 69);
            labelTKH.Margin = new Padding(3, 30, 3, 30);
            labelTKH.Name = "labelTKH";
            labelTKH.Size = new Size(102, 21);
            labelTKH.TabIndex = 14;
            labelTKH.Text = "Khách Hàng";
            // 
            // labelTLS
            // 
            labelTLS.AutoSize = true;
            labelTLS.Font = new Font("Times New Roman", 14.25F);
            labelTLS.ForeColor = Color.FromArgb(177, 148, 95);
            labelTLS.Location = new Point(30, 111);
            labelTLS.Margin = new Padding(3, 30, 3, 30);
            labelTLS.Name = "labelTLS";
            labelTLS.Size = new Size(69, 21);
            labelTLS.TabIndex = 13;
            labelTLS.Text = "Luật Sư";
            // 
            // labelTG
            // 
            labelTG.AutoSize = true;
            labelTG.Font = new Font("Times New Roman", 14.25F);
            labelTG.ForeColor = Color.FromArgb(177, 148, 95);
            labelTG.Location = new Point(30, 192);
            labelTG.Margin = new Padding(3, 30, 3, 30);
            labelTG.Name = "labelTG";
            labelTG.Size = new Size(85, 21);
            labelTG.TabIndex = 12;
            labelTG.Text = "Thời Gian";
            // 
            // labelDD
            // 
            labelDD.AutoSize = true;
            labelDD.Font = new Font("Times New Roman", 14.25F);
            labelDD.ForeColor = Color.FromArgb(177, 148, 95);
            labelDD.Location = new Point(30, 150);
            labelDD.Margin = new Padding(3, 30, 3, 30);
            labelDD.Name = "labelDD";
            labelDD.Size = new Size(81, 21);
            labelDD.TabIndex = 11;
            labelDD.Text = "Địa Điểm";
            // 
            // labelMLH
            // 
            labelMLH.AutoSize = true;
            labelMLH.Font = new Font("Times New Roman", 14.25F);
            labelMLH.ForeColor = Color.FromArgb(177, 148, 95);
            labelMLH.Location = new Point(30, 30);
            labelMLH.Margin = new Padding(3, 30, 3, 30);
            labelMLH.Name = "labelMLH";
            labelMLH.Size = new Size(107, 21);
            labelMLH.TabIndex = 10;
            labelMLH.Text = "Mã Lịch Hẹn";
            // 
            // Calender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 486);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Calender";
            Text = "Calender";
            Load += Calender_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTim;
        private TextBox textBox1;
        private Label lblList;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label labelMLH;
        private Label labelTKH;
        private Label labelTLS;
        private Label labelTG;
        private Label labelDD;
        private Label labeGC;
        private Button buttonTLH;
        private TextBox txtBGhiChu;
        private TextBox txtbThoiGian;
        private TextBox txtBDiaDiem;
        private ComboBox cbBLuatSu;
        private ComboBox cbBKhachHang;
        private TextBox txtBMaLichHen;
        private ComboBox cbBTrangThai;
        private Label label1;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Panel panel5;
        private ComboBox cbBLS;
        private Label label2;
    }
}