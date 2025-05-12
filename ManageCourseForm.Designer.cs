namespace AppQuanLyHocSinh
{
    partial class ManageCourseForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel3 = new Panel();
            button_delete = new Button();
            button_update = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_courseHour = new TextBox();
            label2 = new Label();
            textBox_courseName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            DataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_courseId = new TextBox();
            label3 = new Label();
            button_clear = new Button();
            textBox_search = new TextBox();
            button_search = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 180);
            panel3.Location = new Point(12, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(1073, 10);
            panel3.TabIndex = 67;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(943, 605);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(125, 36);
            button_delete.TabIndex = 66;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.FromArgb(192, 64, 0);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(812, 605);
            button_update.Name = "button_update";
            button_update.Size = new Size(125, 36);
            button_update.TabIndex = 65;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(12, 540);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(587, 101);
            textBox_description.TabIndex = 64;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 180);
            label5.Location = new Point(12, 514);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 63;
            label5.Text = "Description :";
            // 
            // textBox_courseHour
            // 
            textBox_courseHour.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_courseHour.Location = new Point(12, 485);
            textBox_courseHour.Name = "textBox_courseHour";
            textBox_courseHour.Size = new Size(163, 27);
            textBox_courseHour.TabIndex = 62;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 180);
            label2.Location = new Point(12, 459);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 61;
            label2.Text = "Hour :";
            // 
            // textBox_courseName
            // 
            textBox_courseName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_courseName.Location = new Point(12, 429);
            textBox_courseName.Name = "textBox_courseName";
            textBox_courseName.Size = new Size(587, 27);
            textBox_courseName.TabIndex = 60;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 180);
            label1.Location = new Point(12, 403);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 59;
            label1.Text = "Course name :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 180);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 45);
            panel1.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(499, 12);
            label7.Name = "label7";
            label7.Size = new Size(167, 23);
            label7.TabIndex = 0;
            label7.Text = "Manage Course";
            // 
            // DataGridView_course
            // 
            DataGridView_course.AllowUserToAddRows = false;
            DataGridView_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridView_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_course.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_course.ColumnHeadersHeight = 24;
            DataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(0, 71, 180);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridView_course.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridView_course.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.Location = new Point(12, 89);
            DataGridView_course.Name = "DataGridView_course";
            DataGridView_course.RowHeadersVisible = false;
            DataGridView_course.RowHeadersWidth = 51;
            DataGridView_course.RowTemplate.Height = 80;
            DataGridView_course.Size = new Size(1073, 308);
            DataGridView_course.TabIndex = 57;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_course.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_course.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DataGridView_course.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_course.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_course.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_course.ThemeStyle.ReadOnly = false;
            DataGridView_course.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_course.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DataGridView_course.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(0, 71, 180);
            DataGridView_course.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_course.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.Click += DataGridView_course_Click;
            // 
            // textBox_courseId
            // 
            textBox_courseId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_courseId.Location = new Point(444, 485);
            textBox_courseId.Name = "textBox_courseId";
            textBox_courseId.Size = new Size(155, 27);
            textBox_courseId.TabIndex = 69;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 180);
            label3.Location = new Point(444, 459);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 68;
            label3.Text = "Course ID :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.FromArgb(255, 192, 128);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(681, 605);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(125, 36);
            button_clear.TabIndex = 70;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button1_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(776, 56);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(178, 27);
            textBox_search.TabIndex = 72;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(255, 128, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(960, 51);
            button_search.Name = "button_search";
            button_search.Size = new Size(125, 37);
            button_search.TabIndex = 71;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 644);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(textBox_courseId);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_courseHour);
            Controls.Add(label2);
            Controls.Add(textBox_courseName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(DataGridView_course);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button_delete;
        private Button button_update;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_courseHour;
        private Label label2;
        private TextBox textBox_courseName;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_course;
        private TextBox textBox_courseId;
        private Label label3;
        private Button button_clear;
        private TextBox textBox_search;
        private Button button_search;
    }
}