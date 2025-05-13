namespace AppQuanLyHocSinh
{
    partial class ScoreForm
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
            panel3 = new Panel();
            button_add = new Button();
            button_clear = new Button();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_score = new TextBox();
            label2 = new Label();
            textBox_studentId = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button_showScore = new Button();
            button_showStudent = new Button();
            DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            comboBox_selectCourse = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 180);
            panel3.Location = new Point(14, 356);
            panel3.Name = "panel3";
            panel3.Size = new Size(1073, 10);
            panel3.TabIndex = 67;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 180);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(941, 628);
            button_add.Name = "button_add";
            button_add.Size = new Size(125, 36);
            button_add.TabIndex = 66;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.FromArgb(255, 128, 0);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(810, 628);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(125, 36);
            button_clear.TabIndex = 65;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(174, 512);
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
            label5.Location = new Point(37, 515);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 63;
            label5.Text = "Description :";
            // 
            // textBox_score
            // 
            textBox_score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_score.Location = new Point(174, 465);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(163, 32);
            textBox_score.TabIndex = 62;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 180);
            label2.Location = new Point(91, 468);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 61;
            label2.Text = "Score :";
            // 
            // textBox_studentId
            // 
            textBox_studentId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_studentId.Location = new Point(174, 372);
            textBox_studentId.Name = "textBox_studentId";
            textBox_studentId.Size = new Size(163, 32);
            textBox_studentId.TabIndex = 60;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 180);
            label1.Location = new Point(49, 375);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 59;
            label1.Text = "Student Id :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 180);
            panel1.Controls.Add(button_showScore);
            panel1.Controls.Add(button_showStudent);
            panel1.Location = new Point(12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 45);
            panel1.TabIndex = 58;
            // 
            // button_showScore
            // 
            button_showScore.ForeColor = Color.FromArgb(0, 71, 200);
            button_showScore.Location = new Point(895, 3);
            button_showScore.Name = "button_showScore";
            button_showScore.Size = new Size(137, 39);
            button_showScore.TabIndex = 1;
            button_showScore.Text = "Show Score";
            button_showScore.UseVisualStyleBackColor = true;
            button_showScore.Click += button_showScore_Click;
            // 
            // button_showStudent
            // 
            button_showStudent.ForeColor = Color.FromArgb(0, 71, 200);
            button_showStudent.Location = new Point(25, 3);
            button_showStudent.Name = "button_showStudent";
            button_showStudent.Size = new Size(156, 39);
            button_showStudent.TabIndex = 0;
            button_showStudent.Text = "Show Student";
            button_showStudent.UseVisualStyleBackColor = true;
            button_showStudent.Click += button_showStudent_Click;
            // 
            // DataGridView_student
            // 
            DataGridView_student.AllowUserToAddRows = false;
            DataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DataGridView_student.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_student.ColumnHeadersHeight = 24;
            DataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 71, 180);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_student.Location = new Point(12, 50);
            DataGridView_student.Name = "DataGridView_student";
            DataGridView_student.RowHeadersVisible = false;
            DataGridView_student.RowHeadersWidth = 51;
            DataGridView_student.RowTemplate.Height = 80;
            DataGridView_student.Size = new Size(1075, 300);
            DataGridView_student.TabIndex = 57;
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
            // comboBox_selectCourse
            // 
            comboBox_selectCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_selectCourse.FormattingEnabled = true;
            comboBox_selectCourse.Location = new Point(174, 419);
            comboBox_selectCourse.Name = "comboBox_selectCourse";
            comboBox_selectCourse.Size = new Size(587, 31);
            comboBox_selectCourse.TabIndex = 68;
            comboBox_selectCourse.SelectedIndexChanged += comboBox_selectCourse_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 180);
            label3.Location = new Point(14, 422);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 69;
            label3.Text = "Select Course :";
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 728);
            Controls.Add(label3);
            Controls.Add(comboBox_selectCourse);
            Controls.Add(panel3);
            Controls.Add(button_add);
            Controls.Add(button_clear);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_score);
            Controls.Add(label2);
            Controls.Add(textBox_studentId);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(DataGridView_student);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button_add;
        private Button button_clear;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_score;
        private Label label2;
        private TextBox textBox_studentId;
        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private ComboBox comboBox_selectCourse;
        private Label label3;
        private Button button_showScore;
        private Button button_showStudent;
    }
}