namespace AppQuanLyHocSinh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_slide = new Panel();
            button_exit = new Button();
            panel_scoreSubmenu = new Panel();
            button_scorePrint = new Button();
            button_manageScore = new Button();
            button_newScore = new Button();
            button_score = new Button();
            panel_courseSubmenu = new Panel();
            button_coursePrint = new Button();
            button_manageCourse = new Button();
            button_newCourse = new Button();
            button_course = new Button();
            panel_studentmenu = new Panel();
            button_printStd = new Button();
            button_status = new Button();
            button_manageStd = new Button();
            button_registation = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Welcome = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel_slide.SuspendLayout();
            panel_scoreSubmenu.SuspendLayout();
            panel_courseSubmenu.SuspendLayout();
            panel_studentmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 160);
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(panel_scoreSubmenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_courseSubmenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_studentmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(200, 603);
            panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 688);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(10, 0, 0, 0);
            button_exit.Size = new Size(179, 45);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = true;
            // 
            // panel_scoreSubmenu
            // 
            panel_scoreSubmenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_scoreSubmenu.Controls.Add(button_scorePrint);
            panel_scoreSubmenu.Controls.Add(button_manageScore);
            panel_scoreSubmenu.Controls.Add(button_newScore);
            panel_scoreSubmenu.Dock = DockStyle.Top;
            panel_scoreSubmenu.Location = new Point(0, 560);
            panel_scoreSubmenu.Name = "panel_scoreSubmenu";
            panel_scoreSubmenu.Size = new Size(179, 128);
            panel_scoreSubmenu.TabIndex = 5;
            // 
            // button_scorePrint
            // 
            button_scorePrint.Dock = DockStyle.Top;
            button_scorePrint.FlatAppearance.BorderSize = 0;
            button_scorePrint.FlatStyle = FlatStyle.Flat;
            button_scorePrint.ForeColor = Color.White;
            button_scorePrint.Location = new Point(0, 84);
            button_scorePrint.Name = "button_scorePrint";
            button_scorePrint.Padding = new Padding(35, 0, 0, 0);
            button_scorePrint.Size = new Size(179, 42);
            button_scorePrint.TabIndex = 4;
            button_scorePrint.Text = "Print";
            button_scorePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_scorePrint.UseVisualStyleBackColor = true;
            button_scorePrint.Click += button_scorePrint_Click;
            // 
            // button_manageScore
            // 
            button_manageScore.Dock = DockStyle.Top;
            button_manageScore.FlatAppearance.BorderSize = 0;
            button_manageScore.FlatStyle = FlatStyle.Flat;
            button_manageScore.ForeColor = Color.White;
            button_manageScore.Location = new Point(0, 42);
            button_manageScore.Name = "button_manageScore";
            button_manageScore.Padding = new Padding(35, 0, 0, 0);
            button_manageScore.Size = new Size(179, 42);
            button_manageScore.TabIndex = 2;
            button_manageScore.Text = "Manage Score";
            button_manageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_manageScore.UseVisualStyleBackColor = true;
            button_manageScore.Click += button_manageScore_Click;
            // 
            // button_newScore
            // 
            button_newScore.Dock = DockStyle.Top;
            button_newScore.FlatAppearance.BorderSize = 0;
            button_newScore.FlatStyle = FlatStyle.Flat;
            button_newScore.ForeColor = Color.White;
            button_newScore.Location = new Point(0, 0);
            button_newScore.Name = "button_newScore";
            button_newScore.Padding = new Padding(35, 0, 0, 0);
            button_newScore.Size = new Size(179, 42);
            button_newScore.TabIndex = 1;
            button_newScore.Text = "New Score";
            button_newScore.TextAlign = ContentAlignment.MiddleLeft;
            button_newScore.UseVisualStyleBackColor = true;
            button_newScore.Click += button_newScore_Click;
            // 
            // button_score
            // 
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 515);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(179, 45);
            button_score.TabIndex = 4;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = true;
            button_score.Click += button_score_Click;
            // 
            // panel_courseSubmenu
            // 
            panel_courseSubmenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_courseSubmenu.Controls.Add(button_coursePrint);
            panel_courseSubmenu.Controls.Add(button_manageCourse);
            panel_courseSubmenu.Controls.Add(button_newCourse);
            panel_courseSubmenu.Dock = DockStyle.Top;
            panel_courseSubmenu.Location = new Point(0, 394);
            panel_courseSubmenu.Name = "panel_courseSubmenu";
            panel_courseSubmenu.Size = new Size(179, 121);
            panel_courseSubmenu.TabIndex = 3;
            // 
            // button_coursePrint
            // 
            button_coursePrint.Dock = DockStyle.Top;
            button_coursePrint.FlatAppearance.BorderSize = 0;
            button_coursePrint.FlatStyle = FlatStyle.Flat;
            button_coursePrint.ForeColor = Color.White;
            button_coursePrint.Location = new Point(0, 84);
            button_coursePrint.Name = "button_coursePrint";
            button_coursePrint.Padding = new Padding(35, 0, 0, 0);
            button_coursePrint.Size = new Size(179, 42);
            button_coursePrint.TabIndex = 4;
            button_coursePrint.Text = "Print";
            button_coursePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_coursePrint.UseVisualStyleBackColor = true;
            button_coursePrint.Click += button_coursePrint_Click;
            // 
            // button_manageCourse
            // 
            button_manageCourse.Dock = DockStyle.Top;
            button_manageCourse.FlatAppearance.BorderSize = 0;
            button_manageCourse.FlatStyle = FlatStyle.Flat;
            button_manageCourse.ForeColor = Color.White;
            button_manageCourse.Location = new Point(0, 42);
            button_manageCourse.Name = "button_manageCourse";
            button_manageCourse.Padding = new Padding(35, 0, 0, 0);
            button_manageCourse.Size = new Size(179, 42);
            button_manageCourse.TabIndex = 2;
            button_manageCourse.Text = "Manage Course";
            button_manageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_manageCourse.UseVisualStyleBackColor = true;
            button_manageCourse.Click += button_manageCourse_Click;
            // 
            // button_newCourse
            // 
            button_newCourse.Dock = DockStyle.Top;
            button_newCourse.FlatAppearance.BorderSize = 0;
            button_newCourse.FlatStyle = FlatStyle.Flat;
            button_newCourse.ForeColor = Color.White;
            button_newCourse.Location = new Point(0, 0);
            button_newCourse.Name = "button_newCourse";
            button_newCourse.Padding = new Padding(35, 0, 0, 0);
            button_newCourse.Size = new Size(179, 42);
            button_newCourse.TabIndex = 1;
            button_newCourse.Text = "New Course";
            button_newCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newCourse.UseVisualStyleBackColor = true;
            button_newCourse.Click += button_newCourse_Click;
            // 
            // button_course
            // 
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 349);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(179, 45);
            button_course.TabIndex = 2;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = true;
            button_course.Click += button_course_Click;
            // 
            // panel_studentmenu
            // 
            panel_studentmenu.BackColor = Color.FromArgb(0, 71, 200);
            panel_studentmenu.Controls.Add(button_printStd);
            panel_studentmenu.Controls.Add(button_status);
            panel_studentmenu.Controls.Add(button_manageStd);
            panel_studentmenu.Controls.Add(button_registation);
            panel_studentmenu.Dock = DockStyle.Top;
            panel_studentmenu.Location = new Point(0, 170);
            panel_studentmenu.Name = "panel_studentmenu";
            panel_studentmenu.Size = new Size(179, 179);
            panel_studentmenu.TabIndex = 1;
            // 
            // button_printStd
            // 
            button_printStd.Dock = DockStyle.Top;
            button_printStd.FlatAppearance.BorderSize = 0;
            button_printStd.FlatStyle = FlatStyle.Flat;
            button_printStd.ForeColor = Color.White;
            button_printStd.Location = new Point(0, 126);
            button_printStd.Name = "button_printStd";
            button_printStd.Padding = new Padding(35, 0, 0, 0);
            button_printStd.Size = new Size(179, 42);
            button_printStd.TabIndex = 4;
            button_printStd.Text = "Print";
            button_printStd.TextAlign = ContentAlignment.MiddleLeft;
            button_printStd.UseVisualStyleBackColor = true;
            button_printStd.Click += button_printStd_Click;
            // 
            // button_status
            // 
            button_status.Dock = DockStyle.Top;
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.ForeColor = Color.White;
            button_status.Location = new Point(0, 84);
            button_status.Name = "button_status";
            button_status.Padding = new Padding(35, 0, 0, 0);
            button_status.Size = new Size(179, 42);
            button_status.TabIndex = 3;
            button_status.Text = "status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button3_Click;
            // 
            // button_manageStd
            // 
            button_manageStd.Dock = DockStyle.Top;
            button_manageStd.FlatAppearance.BorderSize = 0;
            button_manageStd.FlatStyle = FlatStyle.Flat;
            button_manageStd.ForeColor = Color.White;
            button_manageStd.Location = new Point(0, 42);
            button_manageStd.Name = "button_manageStd";
            button_manageStd.Padding = new Padding(35, 0, 0, 0);
            button_manageStd.Size = new Size(179, 42);
            button_manageStd.TabIndex = 2;
            button_manageStd.Text = "Manage Student";
            button_manageStd.TextAlign = ContentAlignment.MiddleLeft;
            button_manageStd.UseVisualStyleBackColor = true;
            button_manageStd.Click += button_manageStd_Click;
            // 
            // button_registation
            // 
            button_registation.Dock = DockStyle.Top;
            button_registation.FlatAppearance.BorderSize = 0;
            button_registation.FlatStyle = FlatStyle.Flat;
            button_registation.ForeColor = Color.White;
            button_registation.Location = new Point(0, 0);
            button_registation.Name = "button_registation";
            button_registation.Padding = new Padding(35, 0, 0, 0);
            button_registation.Size = new Size(179, 42);
            button_registation.TabIndex = 1;
            button_registation.Text = "Registation";
            button_registation.TextAlign = ContentAlignment.MiddleLeft;
            button_registation.UseVisualStyleBackColor = true;
            button_registation.Click += button_registation_Click;
            // 
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 125);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(179, 45);
            button_std.TabIndex = 1;
            button_std.Text = "Student";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label4);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(179, 125);
            panel_logo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 36);
            label4.Name = "label4";
            label4.Size = new Size(51, 46);
            label4.TabIndex = 3;
            label4.Text = "P";
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 67);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 71, 180);
            label11.Location = new Point(0, 9);
            label11.Name = "label11";
            label11.Size = new Size(366, 35);
            label11.TabIndex = 1;
            label11.Text = "International School";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 180);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Welcome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 67);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.th;
            pictureBox1.Location = new Point(865, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(150, 15);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Prider";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(150, 37);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 37);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Role :";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(37, 15);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(78, 20);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 180);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(200, 515);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 88);
            panel3.TabIndex = 3;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(500, 21);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 7;
            label10.Text = "Select class :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(732, 56);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 6;
            label8.Text = "Female :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(619, 56);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 5;
            label9.Text = "Male :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(599, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 28);
            comboBox1.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(150, 45);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 3;
            label7.Text = "Female :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 45);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 2;
            label6.Text = "Male :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 14);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 1;
            label5.Text = "Total students :";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.class1;
            pictureBox2.Location = new Point(200, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(932, 393);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1132, 603);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_slide);
            MinimumSize = new Size(1150, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_slide.ResumeLayout(false);
            panel_scoreSubmenu.ResumeLayout(false);
            panel_courseSubmenu.ResumeLayout(false);
            panel_studentmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Panel panel_studentmenu;
        private Button button_printStd;
        private Button button_status;
        private Button button_manageStd;
        private Button button_registation;
        private Panel panel_scoreSubmenu;
        private Button button_scorePrint;
        private Button button_manageScore;
        private Button button_newScore;
        private Button button_score;
        private Panel panel_courseSubmenu;
        private Button button_coursePrint;
        private Button button_manageCourse;
        private Button button_newCourse;
        private Button button_course;
        private Button button_exit;
        private Panel panel1;
        private Panel panel2;
        private Label Welcome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox2;
        private Label label11;
        private PictureBox pictureBox1;
    }
}
