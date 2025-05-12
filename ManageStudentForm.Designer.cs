namespace AppQuanLyHocSinh
{
    partial class ManageStudentForm
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
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            button_delete = new Button();
            button_update = new Button();
            textBox_phone = new TextBox();
            label6 = new Label();
            button_upload = new Button();
            pictureBox_student = new PictureBox();
            textBox_address = new TextBox();
            label5 = new Label();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox_lName = new TextBox();
            label2 = new Label();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_fName = new TextBox();
            label1 = new Label();
            button_clearManaStd = new Button();
            button_search = new Button();
            textBox_search = new TextBox();
            textBox_id = new TextBox();
            label_id = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 180);
            panel2.Location = new Point(13, 393);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 10);
            panel2.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 180);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 45);
            panel1.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(463, 9);
            label7.Name = "label7";
            label7.Size = new Size(197, 27);
            label7.TabIndex = 0;
            label7.Text = "Manage Student";
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(931, 582);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(125, 36);
            button_delete.TabIndex = 38;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.FromArgb(192, 64, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(800, 582);
            button_update.Name = "button_update";
            button_update.Size = new Size(125, 36);
            button_update.TabIndex = 37;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_phone.Location = new Point(719, 422);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(178, 32);
            textBox_phone.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 180);
            label6.Location = new Point(630, 425);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 35;
            label6.Text = "Phone :";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_upload.BackColor = Color.FromArgb(0, 192, 0);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(916, 538);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(140, 36);
            button_upload.TabIndex = 34;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_student.BackColor = Color.Silver;
            pictureBox_student.Location = new Point(916, 409);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(140, 123);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 33;
            pictureBox_student.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_address.Location = new Point(142, 507);
            textBox_address.Multiline = true;
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(452, 45);
            textBox_address.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 180);
            label5.Location = new Point(14, 516);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 31;
            label5.Text = "Address :";
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(719, 472);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(105, 27);
            radioButton_female.TabIndex = 30;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Location = new Point(618, 473);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 29;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 180);
            label4.Location = new Point(498, 476);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 28;
            label4.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(160, 469);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 32);
            dateTimePicker1.TabIndex = 27;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 180);
            label3.Location = new Point(13, 476);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 26;
            label3.Text = "Date of birth :";
            // 
            // textBox_lName
            // 
            textBox_lName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_lName.Location = new Point(445, 422);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.Size = new Size(178, 32);
            textBox_lName.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 180);
            label2.Location = new Point(320, 425);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 24;
            label2.Text = "Last name :";
            // 
            // DataGridView_student
            // 
            DataGridView_student.AllowUserToAddRows = false;
            DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_student.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_student.ColumnHeadersHeight = 24;
            DataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 71, 180);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.Location = new Point(12, 84);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(1059, 316);
            DataGridView_student.TabIndex = 23;
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
            DataGridView_student.Click += DataGridView_student_Click;
            // 
            // textBox_fName
            // 
            textBox_fName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_fName.Location = new Point(142, 422);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.Size = new Size(170, 32);
            textBox_fName.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 180);
            label1.Location = new Point(13, 425);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 21;
            label1.Text = "First name :";
            // 
            // button_clearManaStd
            // 
            button_clearManaStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearManaStd.BackColor = Color.FromArgb(255, 128, 0);
            button_clearManaStd.ForeColor = Color.White;
            button_clearManaStd.Location = new Point(669, 581);
            button_clearManaStd.Name = "button_clearManaStd";
            button_clearManaStd.Size = new Size(125, 36);
            button_clearManaStd.TabIndex = 41;
            button_clearManaStd.Text = "Clear";
            button_clearManaStd.UseVisualStyleBackColor = false;
            button_clearManaStd.Click += button_clearManaStd_Click;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(255, 128, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(931, 47);
            button_search.Name = "button_search";
            button_search.Size = new Size(125, 36);
            button_search.TabIndex = 42;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(747, 51);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(178, 32);
            textBox_search.TabIndex = 43;
            // 
            // textBox_id
            // 
            textBox_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_id.Location = new Point(719, 507);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(178, 32);
            textBox_id.TabIndex = 44;
            // 
            // label_id
            // 
            label_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_id.AutoSize = true;
            label_id.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_id.ForeColor = Color.FromArgb(0, 71, 180);
            label_id.Location = new Point(630, 510);
            label_id.Name = "label_id";
            label_id.Size = new Size(72, 23);
            label_id.TabIndex = 45;
            label_id.Text = "Id no :";
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 629);
            Controls.Add(label_id);
            Controls.Add(textBox_id);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clearManaStd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(textBox_phone);
            Controls.Add(label6);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_student);
            Controls.Add(textBox_address);
            Controls.Add(label5);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox_lName);
            Controls.Add(label2);
            Controls.Add(DataGridView_student);
            Controls.Add(textBox_fName);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageStudentForm";
            Text = "ManageStudetnForm";
            Load += ManageStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Button button_delete;
        private Button button_update;
        private TextBox textBox_phone;
        private Label label6;
        private Button button_upload;
        private PictureBox pictureBox_student;
        private TextBox textBox_address;
        private Label label5;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox_lName;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private TextBox textBox_fName;
        private Label label1;
        private Button button_clearManaStd;
        private Button button_search;
        private TextBox textBox_search;
        private TextBox textBox_id;
        private Label label_id;
    }
}