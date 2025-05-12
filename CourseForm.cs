using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyHocSinh
{
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_courseName.Text == "" || textBox_courseHour.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                string courseName = textBox_courseName.Text;
                int courseHour = Convert.ToInt32(textBox_courseHour.Text);
                string description = textBox_description.Text;
                if (course.insertCourse(courseName, courseHour, description))
                {
                    showTable();
                    MessageBox.Show("Course added successfully");
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed to add course");
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_courseName.Clear();
            textBox_courseHour.Clear();
            textBox_description.Clear();
        }

        public void showTable()
        {
            DataGridView_course.DataSource = course.getCourseList(); 
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
           showTable();            
        }
    }
}
