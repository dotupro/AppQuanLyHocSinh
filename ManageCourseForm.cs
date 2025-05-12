using Microsoft.VisualBasic.Devices;
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
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_course.DataSource = course.getCourseList();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showTable();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox_courseId.Clear();
            textBox_courseName.Clear();
            textBox_courseHour.Clear();
            textBox_description.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_courseName.Text == "" || textBox_courseHour.Text == "" || textBox_courseId.Text.Equals(""))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                int id = Convert.ToInt32(textBox_courseId.Text);
                string courseName = textBox_courseName.Text;
                int courseHour = Convert.ToInt32(textBox_courseHour.Text);
                string description = textBox_description.Text;
                if (course.updateCourse(id, courseName, courseHour, description))
                {
                    showTable();
                    MessageBox.Show("Course update successfully");
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed to update course");
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_courseId.Text == "")
            {
                MessageBox.Show("Please select a course to delete");
            }
            else
            {
                int id = Convert.ToInt32(textBox_courseId.Text);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (course.deleteCourse(id))
                    {
                        showTable();
                        MessageBox.Show("Course deleted successfully");
                        button_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete course");
                    }
                }
            }
        }

        private void DataGridView_course_Click(object sender, EventArgs e)
        {
            textBox_courseId.Text = DataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_courseName.Text = DataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_courseHour.Text = DataGridView_course.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridView_course.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = course.searchCourse(textBox_search.Text);
        }
    }
}
