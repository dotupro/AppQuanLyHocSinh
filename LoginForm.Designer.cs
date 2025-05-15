namespace AppQuanLyHocSinh
{
    partial class LoginForm
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
            label5 = new Label();
            P = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 200);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(P);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 84);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(922, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 34);
            label5.TabIndex = 2;
            label5.Text = "X";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // P
            // 
            P.AutoSize = true;
            P.BorderStyle = BorderStyle.FixedSingle;
            P.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            P.ForeColor = Color.White;
            P.Location = new Point(44, 19);
            P.Name = "P";
            P.Size = new Size(48, 51);
            P.TabIndex = 1;
            P.Text = "P";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 37);
            label1.Name = "label1";
            label1.Size = new Size(239, 27);
            label1.TabIndex = 0;
            label1.Text = "International School";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 200);
            label2.Location = new Point(337, 221);
            label2.Name = "label2";
            label2.Size = new Size(231, 34);
            label2.TabIndex = 1;
            label2.Text = "Please login first";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.FromArgb(0, 71, 200);
            label3.Location = new Point(313, 275);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.FromArgb(0, 71, 200);
            label4.Location = new Point(313, 344);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(313, 301);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(286, 27);
            textBox_username.TabIndex = 4;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(313, 370);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(286, 27);
            textBox_password.TabIndex = 5;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(0, 71, 200);
            button_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(313, 419);
            button_login.Name = "button_login";
            button_login.Size = new Size(286, 40);
            button_login.TabIndex = 6;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 614);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label P;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Button button_login;
        private Label label5;
    }
}