namespace AppQuanLyHocSinh
{
    partial class PrinterScoreForm
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
            textBox_search = new TextBox();
            button_search = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            button_print = new Button();
            DataGridView_score = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).BeginInit();
            SuspendLayout();
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(617, 52);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(198, 32);
            textBox_search.TabIndex = 90;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 200);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(821, 46);
            button_search.Name = "button_search";
            button_search.Size = new Size(149, 41);
            button_search.TabIndex = 89;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 180);
            panel2.Location = new Point(12, 457);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 10);
            panel2.TabIndex = 88;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 180);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 49);
            panel1.TabIndex = 87;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(402, 8);
            label7.Name = "label7";
            label7.Size = new Size(130, 27);
            label7.TabIndex = 0;
            label7.Text = "Course List";
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 192, 0);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(821, 486);
            button_print.Name = "button_print";
            button_print.Size = new Size(149, 36);
            button_print.TabIndex = 86;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
            // 
            // DataGridView_score
            // 
            DataGridView_score.AllowUserToAddRows = false;
            DataGridView_score.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridView_score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridView_score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_score.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridView_score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridView_score.ColumnHeadersHeight = 24;
            DataGridView_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(0, 71, 180);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridView_score.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridView_score.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_score.Location = new Point(12, 88);
            DataGridView_score.Name = "DataGridView_score";
            DataGridView_score.RowHeadersVisible = false;
            DataGridView_score.RowHeadersWidth = 51;
            DataGridView_score.RowTemplate.Height = 80;
            DataGridView_score.Size = new Size(958, 376);
            DataGridView_score.TabIndex = 85;
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
            // 
            // PrintScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_print);
            Controls.Add(DataGridView_score);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PrintScoreForm";
            Text = "PrintScoreForm";
            Load += PrintScoreForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_search;
        private Button button_search;
        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Button button_print;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_score;
    }
}