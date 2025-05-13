namespace AppQuanLyHocSinh
{
    public partial class MainForm : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        public MainForm()
        {
            InitializeComponent();
            customDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DataSource = course.getCourseList();
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            studentCount();
        }

        private void studentCount()
        {
            label_totalStd.Text = "Total Student: " + student.totalStudent();
            label_male.Text = "Male: " + student.maleStudent();
            label_female.Text = "Female: " + student.femaleStudent();
        }

        private void customDesign()
        {
            panel_studentmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_studentmenu.Visible == true)
                panel_studentmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
        }

        private void showMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_course_Click(object sender, EventArgs e)
        {
            showMenu(panel_courseSubmenu);
        }

        private void button_newScore_Click(object sender, EventArgs e)
        {
            openchildForm(new ScoreForm());
            hideSubmenu();
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showMenu(panel_studentmenu);
        }

        private void button_registation_Click(object sender, EventArgs e)
        {
            openchildForm(new RegistationForm());
            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openchildForm(new ManageStudentForm());
            hideSubmenu();
        }

        private void button_printStd_Click(object sender, EventArgs e)
        {
            openchildForm(new PrintStdForm());
            hideSubmenu();
        }

        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openchildForm(new CourseForm());
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openchildForm(new ManageCourseForm());
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            openchildForm(new PrinterCourseForm());
            hideSubmenu();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showMenu(panel_scoreSubmenu);
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openchildForm(new ManageScoreForm());
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrinterScoreForm());
            hideSubmenu();
        }

        private Form activeform = null;
        private void openchildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_db_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            panel_main.Controls.Add(activeform);
            studentCount();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
