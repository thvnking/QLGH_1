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
            panel1 = new Panel();
            label1 = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            labelUser = new Label();
            labelPass = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            buttonMi = new Button();
            buttonClose = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 52, 72);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 310);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("ROG Fonts", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(148, 180, 193);
            label1.Location = new Point(13, 114);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(278, 58);
            label1.TabIndex = 8;
            label1.Text = "DEF4ST";
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(234, 224, 207);
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.Location = new Point(476, 122);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(256, 22);
            textBoxUser.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(234, 224, 207);
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.Location = new Point(476, 171);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(256, 22);
            textBoxPass.TabIndex = 2;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUser.Location = new Point(367, 114);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(103, 30);
            labelUser.TabIndex = 3;
            labelUser.Text = "Tài Khoản";
            labelUser.Click += label2_Click;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPass.Location = new Point(367, 163);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(103, 30);
            labelPass.TabIndex = 4;
            labelPass.Text = "Mật Khẩu";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(148, 180, 193);
            panel3.Location = new Point(372, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 3);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(148, 180, 193);
            panel4.Location = new Point(372, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 3);
            panel4.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 52, 72);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(148, 180, 193);
            button1.Location = new Point(450, 211);
            button1.Name = "button1";
            button1.Size = new Size(226, 50);
            button1.TabIndex = 5;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(buttonMi);
            panel2.Controls.Add(buttonClose);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 310);
            panel2.TabIndex = 6;
            // 
            // buttonMi
            // 
            buttonMi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMi.BackColor = Color.Transparent;
            buttonMi.FlatAppearance.BorderSize = 0;
            buttonMi.FlatStyle = FlatStyle.Flat;
            buttonMi.Font = new Font("ROG Fonts", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMi.Location = new Point(686, -11);
            buttonMi.Margin = new Padding(0);
            buttonMi.Name = "buttonMi";
            buttonMi.Size = new Size(52, 31);
            buttonMi.TabIndex = 7;
            buttonMi.Text = "-";
            buttonMi.UseVisualStyleBackColor = false;
            buttonMi.Click += button2_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.IndianRed;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("ROG Fonts", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(738, -9);
            buttonClose.Margin = new Padding(0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(52, 31);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("ROG Fonts", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(33, 52, 72);
            label3.Location = new Point(422, 37);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(282, 58);
            label3.TabIndex = 4;
            label3.Text = "DES4ST";
            // 
            // Sign_in
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 224, 207);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 310);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(33, 52, 72);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Sign_in";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_in";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Label labelUser;
        private Label labelPass;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private Button buttonClose;
        private Button buttonMi;
        private Label label1;
    }
}