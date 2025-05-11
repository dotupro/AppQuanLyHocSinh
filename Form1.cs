namespace AppQuanLyHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customDesign();
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
            hideSubmenu();
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showMenu(panel_studentmenu);
        }

        private void button_registation_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_printStd_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_newCourse_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showMenu(panel_scoreSubmenu);
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
