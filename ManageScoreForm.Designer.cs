namespace AppQuanLyHocSinh
{
    partial class ManageScoreForm
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
            textBox_search = new TextBox();
            button_search = new Button();
            button_clear = new Button();
            panel3 = new Panel();
            button_delete = new Button();
            button_update = new Button();
            panel1 = new Panel();
            label7 = new Label();
            DataGridView_score = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            comboBox_selectCourse = new ComboBox();
            textBox_description = new TextBox();
            label5 = new Label();
            textBox_score = new TextBox();
            label2 = new Label();
            textBox_studentId = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).BeginInit();
            SuspendLayout();
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(776, 56);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(178, 32);
            textBox_search.TabIndex = 88;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(255, 128, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(960, 51);
            button_search.Name = "button_search";
            button_search.Size = new Size(125, 37);
            button_search.TabIndex = 87;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.FromArgb(255, 192, 128);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(681, 605);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(125, 36);
            button_clear.TabIndex = 86;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 180);
            panel3.Location = new Point(12, 346);
            panel3.Name = "panel3";
            panel3.Size = new Size(1073, 10);
            panel3.TabIndex = 83;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(943, 605);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(125, 36);
            button_delete.TabIndex = 82;
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
            button_update.TabIndex = 81;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 180);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 45);
            panel1.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(499, 12);
            label7.Name = "label7";
            label7.Size = new Size(153, 23);
            label7.TabIndex = 0;
            label7.Text = "Manage Score";
            // 
            // DataGridView_score
            // 
            DataGridView_score.AllowUserToAddRows = false;
            DataGridView_score.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_score.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_score.ColumnHeadersHeight = 24;
            DataGridView_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 71, 180);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_score.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_score.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.Location = new Point(12, 89);
            DataGridView_score.Name = "DataGridView_score";
            DataGridView_score.RowHeadersVisible = false;
            DataGridView_score.RowHeadersWidth = 51;
            DataGridView_score.RowTemplate.Height = 80;
            DataGridView_score.Size = new Size(1073, 267);
            DataGridView_score.TabIndex = 73;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_score.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_score.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_score.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_score.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_score.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DataGridView_score.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_score.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_score.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_score.ThemeStyle.ReadOnly = false;
            DataGridView_score.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_score.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_score.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            DataGridView_score.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(0, 71, 180);
            DataGridView_score.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_score.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_score.Click += DataGridView_score_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 180);
            label3.Location = new Point(10, 408);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 96;
            label3.Text = "Select Course :";
            // 
            // comboBox_selectCourse
            // 
            comboBox_selectCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_selectCourse.FormattingEnabled = true;
            comboBox_selectCourse.Location = new Point(170, 405);
            comboBox_selectCourse.Name = "comboBox_selectCourse";
            comboBox_selectCourse.Size = new Size(587, 31);
            comboBox_selectCourse.TabIndex = 95;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Location = new Point(170, 498);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(587, 101);
            textBox_description.TabIndex = 94;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 180);
            label5.Location = new Point(33, 501);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 93;
            label5.Text = "Description :";
            // 
            // textBox_score
            // 
            textBox_score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_score.Location = new Point(170, 451);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(163, 32);
            textBox_score.TabIndex = 92;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 180);
            label2.Location = new Point(87, 454);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 91;
            label2.Text = "Score :";
            // 
            // textBox_studentId
            // 
            textBox_studentId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_studentId.Location = new Point(170, 358);
            textBox_studentId.Name = "textBox_studentId";
            textBox_studentId.Size = new Size(163, 32);
            textBox_studentId.TabIndex = 90;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 180);
            label1.Location = new Point(45, 361);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 89;
            label1.Text = "Student Id :";
            // 
            // ManageScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 644);
            Controls.Add(label3);
            Controls.Add(comboBox_selectCourse);
            Controls.Add(textBox_description);
            Controls.Add(label5);
            Controls.Add(textBox_score);
            Controls.Add(label2);
            Controls.Add(textBox_studentId);
            Controls.Add(label1);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(panel3);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(panel1);
            Controls.Add(DataGridView_score);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageScoreForm";
            Text = "ManageScoreForm";
            Load += ManageScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_search;
        private Button button_search;
        private Button button_clear;
        private Panel panel3;
        private Button button_delete;
        private Button button_update;
        private Panel panel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_score;
        private Label label3;
        private ComboBox comboBox_selectCourse;
        private TextBox textBox_description;
        private Label label5;
        private TextBox textBox_score;
        private Label label2;
        private TextBox textBox_studentId;
        private Label label1;
    }
}