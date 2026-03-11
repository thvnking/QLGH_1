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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnTim = new Button();
            textBox1 = new TextBox();
            lblList = new Label();
            BtnThem = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 52, 72);
            panel1.Controls.Add(btnTim);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblList);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 100);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
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
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 14.25F);
            textBox1.Location = new Point(785, 9);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.FromArgb(177, 148, 95);
            lblList.Location = new Point(3, 9);
            lblList.Name = "lblList";
            lblList.Size = new Size(295, 73);
            lblList.TabIndex = 0;
            lblList.Text = "Order List";
            lblList.Click += lblList_Click;
            // 
            // BtnThem
            // 
            BtnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnThem.BackColor = Color.FromArgb(29, 60, 107);
            BtnThem.FlatStyle = FlatStyle.Flat;
            BtnThem.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnThem.ForeColor = Color.FromArgb(177, 148, 95);
            BtnThem.Location = new Point(21, 73);
            BtnThem.Margin = new Padding(5);
            BtnThem.Name = "BtnThem";
            BtnThem.Size = new Size(90, 29);
            BtnThem.TabIndex = 3;
            BtnThem.Text = "Thêm";
            BtnThem.UseVisualStyleBackColor = false;
            BtnThem.Click += BtnThem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 60, 107);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 107);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(29, 60, 107);
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 207);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(30);
            panel4.Size = new Size(1110, 499);
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
            dataGridView1.Location = new Point(30, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1050, 439);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            dataGridView2.Location = new Point(30, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(909, 77);
            dataGridView2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnThem);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(969, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 107);
            panel2.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(30, 30, 30, 0);
            panel5.Size = new Size(969, 107);
            panel5.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 224, 207);
            ClientSize = new Size(1110, 706);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.AppWorkspace;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnTim;
        private Panel panel1;
        private Label lblList;
        private Button BtnThem;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private DataGridView dataGridView2;
        private Panel panel2;
    }
}