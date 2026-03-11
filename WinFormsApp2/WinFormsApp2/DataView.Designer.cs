namespace WinFormsApp2
{
    partial class DataView
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel4 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            textBoxTLS = new TextBox();
            textBoxTKH = new TextBox();
            textBoxTHD = new TextBox();
            textBoxMHD = new TextBox();
            labelTLS = new Label();
            labelTKH = new Label();
            labelTHD = new Label();
            labelMHD = new Label();
            BtnThem = new Button();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            btnTim = new Button();
            lblList = new Label();
            textBox1 = new TextBox();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(29, 60, 107);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(744, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(366, 606);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 169);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30);
            panel5.Size = new Size(366, 437);
            panel5.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(234, 224, 207);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(30, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(684, 546);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxTLS);
            panel2.Controls.Add(textBoxTKH);
            panel2.Controls.Add(textBoxTHD);
            panel2.Controls.Add(textBoxMHD);
            panel2.Controls.Add(labelTLS);
            panel2.Controls.Add(labelTKH);
            panel2.Controls.Add(labelTHD);
            panel2.Controls.Add(labelMHD);
            panel2.Controls.Add(BtnThem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 169);
            panel2.TabIndex = 9;
            // 
            // textBoxTLS
            // 
            textBoxTLS.BackColor = Color.FromArgb(29, 60, 107);
            textBoxTLS.BorderStyle = BorderStyle.None;
            textBoxTLS.Font = new Font("Times New Roman", 12F);
            textBoxTLS.ForeColor = Color.FromArgb(177, 148, 95);
            textBoxTLS.Location = new Point(153, 124);
            textBoxTLS.Name = "textBoxTLS";
            textBoxTLS.Size = new Size(207, 19);
            textBoxTLS.TabIndex = 16;
            // 
            // textBoxTKH
            // 
            textBoxTKH.BackColor = Color.FromArgb(29, 60, 107);
            textBoxTKH.BorderStyle = BorderStyle.None;
            textBoxTKH.Font = new Font("Times New Roman", 12F);
            textBoxTKH.ForeColor = Color.FromArgb(177, 148, 95);
            textBoxTKH.Location = new Point(153, 92);
            textBoxTKH.Name = "textBoxTKH";
            textBoxTKH.Size = new Size(207, 19);
            textBoxTKH.TabIndex = 15;
            // 
            // textBoxTHD
            // 
            textBoxTHD.BackColor = Color.FromArgb(29, 60, 107);
            textBoxTHD.BorderStyle = BorderStyle.None;
            textBoxTHD.Font = new Font("Times New Roman", 12F);
            textBoxTHD.ForeColor = Color.FromArgb(177, 148, 95);
            textBoxTHD.Location = new Point(153, 60);
            textBoxTHD.Name = "textBoxTHD";
            textBoxTHD.Size = new Size(207, 19);
            textBoxTHD.TabIndex = 14;
            // 
            // textBoxMHD
            // 
            textBoxMHD.BackColor = Color.FromArgb(29, 60, 107);
            textBoxMHD.BorderStyle = BorderStyle.None;
            textBoxMHD.Font = new Font("Times New Roman", 12F);
            textBoxMHD.ForeColor = Color.FromArgb(177, 148, 95);
            textBoxMHD.Location = new Point(153, 28);
            textBoxMHD.Name = "textBoxMHD";
            textBoxMHD.Size = new Size(85, 19);
            textBoxMHD.TabIndex = 13;
            // 
            // labelTLS
            // 
            labelTLS.AutoSize = true;
            labelTLS.Font = new Font("Times New Roman", 14.25F);
            labelTLS.ForeColor = Color.FromArgb(177, 148, 95);
            labelTLS.Location = new Point(6, 126);
            labelTLS.Name = "labelTLS";
            labelTLS.Size = new Size(103, 21);
            labelTLS.TabIndex = 12;
            labelTLS.Text = "Tên Luật Sư";
            // 
            // labelTKH
            // 
            labelTKH.AutoSize = true;
            labelTKH.Font = new Font("Times New Roman", 14.25F);
            labelTKH.ForeColor = Color.FromArgb(177, 148, 95);
            labelTKH.Location = new Point(6, 94);
            labelTKH.Name = "labelTKH";
            labelTKH.Size = new Size(136, 21);
            labelTKH.TabIndex = 11;
            labelTKH.Text = "Tên Khách Hàng";
            // 
            // labelTHD
            // 
            labelTHD.AutoSize = true;
            labelTHD.Font = new Font("Times New Roman", 14.25F);
            labelTHD.ForeColor = Color.FromArgb(177, 148, 95);
            labelTHD.Location = new Point(6, 62);
            labelTHD.Name = "labelTHD";
            labelTHD.Size = new Size(124, 21);
            labelTHD.TabIndex = 10;
            labelTHD.Text = "Tên Hợp Đồng";
            // 
            // labelMHD
            // 
            labelMHD.AutoSize = true;
            labelMHD.Font = new Font("Times New Roman", 14.25F);
            labelMHD.ForeColor = Color.FromArgb(177, 148, 95);
            labelMHD.Location = new Point(6, 30);
            labelMHD.Name = "labelMHD";
            labelMHD.Size = new Size(119, 21);
            labelMHD.TabIndex = 9;
            labelMHD.Text = "Mã Hợp Đồng";
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnThem.BackColor = Color.FromArgb(29, 60, 107);
            BtnThem.FlatStyle = FlatStyle.Flat;
            BtnThem.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnThem.ForeColor = Color.FromArgb(177, 148, 95);
            BtnThem.Location = new Point(246, 25);
            BtnThem.Margin = new Padding(5);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(90, 29);
            BtnThem.TabIndex = 8;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 60, 107);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30);
            panel3.Size = new Size(744, 606);
            panel3.TabIndex = 11;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(33, 52, 72);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(148, 180, 193);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(148, 180, 193);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle8.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(30, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(306, 377);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 52, 72);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(lblList);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 100);
            panel1.TabIndex = 12;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.BackColor = Color.FromArgb(29, 60, 107);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Times New Roman", 14.25F);
            btnTim.ForeColor = Color.FromArgb(177, 148, 95);
            btnTim.Location = new Point(990, 9);
            btnTim.Margin = new Padding(0);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 29);
            btnTim.TabIndex = 6;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.FromArgb(177, 148, 95);
            lblList.Location = new Point(0, 9);
            lblList.Name = "lblList";
            lblList.Size = new Size(295, 73);
            lblList.TabIndex = 0;
            lblList.Text = "Order List";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 14.25F);
            textBox1.Location = new Point(785, 9);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 29);
            textBox1.TabIndex = 7;
            // 
            // DataView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 706);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "DataView";
            Text = "DataView";
            Load += DataView_Load;
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Label lblList;
        private Button btnTim;
        private TextBox textBox1;
        private Button BtnThem;
        private Panel panel5;
        private Panel panel2;
        private Label labelTLS;
        private Label labelTKH;
        private Label labelTHD;
        private Label labelMHD;
        private TextBox textBoxMHD;
        private TextBox textBoxTLS;
        private TextBox textBoxTKH;
        private TextBox textBoxTHD;
    }
}