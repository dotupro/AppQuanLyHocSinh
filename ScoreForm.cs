using MySql.Data.MySqlClient;
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
    public partial class ScoreForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
        }

        public void showScore()
        {
            DataGridView_student.DataSource = score.getScoreList();
        }

        //public void showTable()
        //{
        //    DataGridView_score.DataSource = score.getScoreList();
        //    DataGridView_student.DataSource = student.getStudentList();
        //}

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            comboBox_selectCourse.DataSource = course.getCourseList();
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseName";
            showScore();

            DataGridView_student.DataSource = student.getStudentList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || textBox_score.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                int studentId = Convert.ToInt32(textBox_studentId.Text);
                string courseName = comboBox_selectCourse.Text;
                float scoreValue = float.Parse(textBox_score.Text);
                string description = textBox_description.Text;

                if (score.checkScore(studentId, courseName))
                {
                    if (score.insertScore(studentId, courseName, scoreValue, description))
                    {
                        showScore();
                        MessageBox.Show("Score added successfully");
                        button_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add score");
                    }
                }
                else
                {
                    MessageBox.Show("This student already has a score for this course");

                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_score.Clear();
            textBox_studentId.Clear();
            textBox_description.Clear();
            comboBox_selectCourse.SelectedIndex = 0;
        }

        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text = DataGridView_student.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_showStudent_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.getStudentList();
        }

        private void button_showScore_Click(object sender, EventArgs e)
        {
            showScore();
        }

        private void comboBox_selectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
