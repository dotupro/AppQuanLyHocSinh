namespace AppQuanLyHocSinh
{
    partial class RegistationForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button_add = new Button();
            button_clear = new Button();
            textBox_phone = new TextBox();
            label6 = new Label();
            button_upload = new Button();
            pictureBox_student = new PictureBox();
            textBox_address = new TextBox();
            label5 = new Label();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label4 = new Label();
            dateTimePicker_bDate = new DateTimePicker();
            label3 = new Label();
            textBox_lName = new TextBox();
            label2 = new Label();
            textBox_fName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            SuspendLayout();
            // 
            // DataGridView_student
            // 
            DataGridView_student.AllowUserToAddRows = false;
            DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            DataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_student.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DataGridView_student.ColumnHeadersHeight = 24;
            DataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 71, 180);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DataGridView_student.DefaultCellStyle = dataGridViewCellStyle9;
            DataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.Location = new Point(12, 51);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(1044, 292);
            DataGridView_student.TabIndex = 3;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_student.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_student.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_student.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_student.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_student.ThemeStyle.ReadOnly = false;
            DataGridView_student.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_student.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DataGridView_student.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(0, 71, 180);
            DataGridView_student.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_student.CellContentClick += DataGridView_student_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 180);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 45);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(463, 9);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 0;
            label7.Text = "Registation";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_student);
            panel2.Controls.Add(textBox_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker_bDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_lName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_fName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 344);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 269);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 180);
            panel3.Location = new Point(12, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 10);
            panel3.TabIndex = 38;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 180);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(931, 203);
            button_add.Name = "button_add";
            button_add.Size = new Size(125, 36);
            button_add.TabIndex = 37;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.FromArgb(0, 71, 180);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(800, 203);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(125, 36);
            button_clear.TabIndex = 36;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Location = new Point(702, 16);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(163, 32);
            textBox_phone.TabIndex = 35;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 180);
            label6.Location = new Point(613, 19);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 34;
            label6.Text = "Phone :";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.None;
            button_upload.BackColor = Color.FromArgb(0, 71, 180);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(931, 145);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(125, 36);
            button_upload.TabIndex = 33;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.None;
            pictureBox_student.BackColor = Color.Silver;
            pictureBox_student.Location = new Point(931, 16);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(125, 123);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 32;
            pictureBox_student.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.None;
            textBox_address.Location = new Point(151, 124);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(658, 45);
            textBox_address.TabIndex = 31;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 180);
            label5.Location = new Point(23, 133);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 30;
            label5.Text = "Address :";
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(729, 66);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(104, 27);
            radioButton_female.TabIndex = 29;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.None;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Location = new Point(628, 67);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 28;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 180);
            label4.Location = new Point(508, 70);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 27;
            label4.Text = "Gender :";
            // 
            // dateTimePicker_bDate
            // 
            dateTimePicker_bDate.Anchor = AnchorStyles.None;
            dateTimePicker_bDate.Location = new Point(170, 63);
            dateTimePicker_bDate.Name = "dateTimePicker_bDate";
            dateTimePicker_bDate.Size = new Size(250, 32);
            dateTimePicker_bDate.TabIndex = 26;
            dateTimePicker_bDate.ValueChanged += dateTimePicker_bDate_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 180);
            label3.Location = new Point(23, 70);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 25;
            label3.Text = "Date of birth :";
            // 
            // textBox_lName
            // 
            textBox_lName.Anchor = AnchorStyles.None;
            textBox_lName.Location = new Point(441, 16);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(163, 32);
            textBox_lName.TabIndex = 24;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 180);
            label2.Location = new Point(316, 19);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 23;
            label2.Text = "Last name :";
            // 
            // textBox_fName
            // 
            textBox_fName.Anchor = AnchorStyles.None;
            textBox_fName.Location = new Point(152, 16);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(155, 32);
            textBox_fName.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 180);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 21;
            label1.Text = "First name :";
            // 
            // RegistationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DataGridView_student);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            ForeColor = Color.FromArgb(0, 71, 180);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistationForm";
            Load += RegistationForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
        private Button button_add;
        private Button button_clear;
        private TextBox textBox_phone;
        private Label label6;
        private Button button_upload;
        private PictureBox pictureBox_student;
        private TextBox textBox_address;
        private Label label5;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private Label label4;
        private DateTimePicker dateTimePicker_bDate;
        private Label label3;
        private TextBox textBox_lName;
        private Label label2;
        private TextBox textBox_fName;
        private Label label1;
    }
}