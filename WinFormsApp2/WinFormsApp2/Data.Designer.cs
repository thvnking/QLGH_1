namespace WinFormsApp2
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnTim = new Button();
            lblList = new Label();
            BtnThem = new Button();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            btnChiTiet = new Button();
            btnPhanCong = new Button();
            btnDuyet = new Button();
            comboBox1 = new ComboBox();
            cbbMNV = new ComboBox();
            btnLoc = new Button();
            cbbTrangThai = new ComboBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(lblList);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 86);
            panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(785, 4);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 35);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.BackColor = Color.FromArgb(33, 52, 72);
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTim.ForeColor = Color.FromArgb(148, 180, 193);
            btnTim.Location = new Point(990, 9);
            btnTim.Margin = new Padding(0);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 30);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.FromArgb(33, 52, 72);
            lblList.Location = new Point(3, 4);
            lblList.Name = "lblList";
            lblList.Size = new Size(250, 65);
            lblList.TabIndex = 0;
            lblList.Text = "Order List";
            lblList.Click += lblList_Click;
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnThem.BackColor = Color.FromArgb(33, 52, 72);
            BtnThem.FlatStyle = FlatStyle.Flat;
            BtnThem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BtnThem.ForeColor = Color.FromArgb(148, 180, 193);
            BtnThem.Location = new Point(990, 56);
            BtnThem.Margin = new Padding(5);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(90, 30);
            BtnThem.TabIndex = 3;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(70, 0, 70, 0);
            panel2.Size = new Size(1110, 80);
            panel2.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 52, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(148, 180, 193);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(148, 180, 193);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(70, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(970, 80);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(btnChiTiet);
            panel3.Controls.Add(btnPhanCong);
            panel3.Controls.Add(btnDuyet);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(cbbMNV);
            panel3.Controls.Add(btnLoc);
            panel3.Controls.Add(cbbTrangThai);
            panel3.Controls.Add(BtnThem);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 94);
            panel3.TabIndex = 6;
            // 
            // btnChiTiet
            // 
            btnChiTiet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChiTiet.BackColor = Color.FromArgb(33, 52, 72);
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnChiTiet.ForeColor = Color.FromArgb(148, 180, 193);
            btnChiTiet.Location = new Point(890, 56);
            btnChiTiet.Margin = new Padding(5);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(90, 30);
            btnChiTiet.TabIndex = 12;
            btnChiTiet.Text = "Chi Tiết";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // btnPhanCong
            // 
            btnPhanCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPhanCong.BackColor = Color.FromArgb(33, 52, 72);
            btnPhanCong.FlatStyle = FlatStyle.Flat;
            btnPhanCong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPhanCong.ForeColor = Color.FromArgb(148, 180, 193);
            btnPhanCong.Location = new Point(890, 17);
            btnPhanCong.Margin = new Padding(5);
            btnPhanCong.Name = "btnPhanCong";
            btnPhanCong.Size = new Size(190, 30);
            btnPhanCong.TabIndex = 11;
            btnPhanCong.Text = "Phân Công Đơn Hàng";
            btnPhanCong.UseVisualStyleBackColor = false;
            btnPhanCong.Click += btnPhanCong_Click;
            // 
            // btnDuyet
            // 
            btnDuyet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDuyet.BackColor = Color.FromArgb(33, 52, 72);
            btnDuyet.FlatStyle = FlatStyle.Flat;
            btnDuyet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDuyet.ForeColor = Color.FromArgb(148, 180, 193);
            btnDuyet.Location = new Point(790, 56);
            btnDuyet.Margin = new Padding(5);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(90, 30);
            btnDuyet.TabIndex = 10;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(660, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Trạng Thái";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbbMNV
            // 
            cbbMNV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbbMNV.FormattingEnabled = true;
            cbbMNV.Location = new Point(157, 59);
            cbbMNV.Name = "cbbMNV";
            cbbMNV.Size = new Size(121, 29);
            cbbMNV.TabIndex = 8;
            cbbMNV.Text = "Mã Nhân viên";
            cbbMNV.SelectedIndexChanged += cbbMNV_SelectedIndexChanged;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoc.BackColor = Color.FromArgb(33, 52, 72);
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLoc.ForeColor = Color.FromArgb(148, 180, 193);
            btnLoc.Location = new Point(286, 59);
            btnLoc.Margin = new Padding(5);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(90, 30);
            btnLoc.TabIndex = 7;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Location = new Point(30, 59);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(121, 29);
            cbbTrangThai.TabIndex = 6;
            cbbTrangThai.Text = "Trạng Thái";
            cbbTrangThai.SelectedIndexChanged += cbbTrangThai_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 260);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30, 0, 30, 0);
            panel4.Size = new Size(1110, 446);
            panel4.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(234, 224, 207);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(30, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1050, 446);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 224, 207);
            ClientSize = new Size(1110, 706);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.AppWorkspace;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTim;
        private Panel panel1;
        private Panel panel2;
        private Label lblList;
        private Button BtnThem;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridView2;
        private Label label1;
        private ComboBox cbbTrangThai;
        private Button btnLoc;
        private ComboBox cbbMNV;
        private Button btnDuyet;
        private ComboBox comboBox1;
        private Button btnPhanCong;
        private DataGridView dataGridView1;
        private Button btnChiTiet;
    }
}