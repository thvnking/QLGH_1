namespace WinFormsApp2
{
    partial class Sign_in
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
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            labelUser = new Label();
            labelPass = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(29, 60, 107);
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Times New Roman", 20.25F);
            textBoxUser.ForeColor = Color.FromArgb(177, 148, 95);
            textBoxUser.Location = new Point(178, 9);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(272, 32);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(29, 60, 107);
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Font = new Font("Times New Roman", 20.25F);
            textBoxPass.ForeColor = Color.FromArgb(177, 148, 95);
            textBoxPass.Location = new Point(178, 56);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(272, 32);
            textBoxPass.TabIndex = 2;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Times New Roman", 20.25F);
            labelUser.ForeColor = Color.FromArgb(177, 148, 95);
            labelUser.Location = new Point(12, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(129, 31);
            labelUser.TabIndex = 3;
            labelUser.Text = "Tài Khoản";
            labelUser.Click += label2_Click;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Times New Roman", 20.25F);
            labelPass.ForeColor = Color.FromArgb(177, 148, 95);
            labelPass.Location = new Point(12, 56);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(124, 31);
            labelPass.TabIndex = 4;
            labelPass.Text = "Mật Khẩu";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(29, 60, 107);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(177, 148, 95);
            button1.Location = new Point(0, 104);
            button1.Name = "button1";
            button1.Size = new Size(460, 43);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 235);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 88);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(23, 47, 84);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("SimSun-ExtB", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(177, 148, 95);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(460, 88);
            label3.TabIndex = 4;
            label3.Text = "AlberlaW";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(29, 60, 107);
            panel3.Controls.Add(textBoxPass);
            panel3.Controls.Add(labelPass);
            panel3.Controls.Add(textBoxUser);
            panel3.Controls.Add(labelUser);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 147);
            panel3.TabIndex = 9;
            // 
            // Sign_in
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(234, 224, 207);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 235);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(33, 52, 72);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "Sign_in";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_in";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Label labelUser;
        private Label labelPass;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Panel panel3;
    }
}