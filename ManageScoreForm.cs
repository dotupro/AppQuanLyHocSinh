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
    public partial class ManageScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_score.DataSource = score.getScoreList();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void DataGridView_score_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text = DataGridView_score.CurrentRow.Cells[0].Value.ToString();
            comboBox_selectCourse.Text = DataGridView_score.CurrentRow.Cells[1].Value.ToString();
            textBox_score.Text = DataGridView_score.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridView_score.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_studentId.Clear();
            textBox_score.Clear();
            textBox_description.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || comboBox_selectCourse.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                int studentId = Convert.ToInt32(textBox_studentId.Text);
                string courseName = comboBox_selectCourse.Text;
                if (score.deleteScore(studentId, courseName))
                {
                    showTable();
                    MessageBox.Show("Score deleted successfully");
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed to delete score");
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || comboBox_selectCourse.Text == "" || textBox_score.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                int studentId = Convert.ToInt32(textBox_studentId.Text);
                string courseName = comboBox_selectCourse.Text;
                float scoreValue = float.Parse(textBox_score.Text);
                string description = textBox_description.Text;
                if (score.updateScore(studentId, courseName, scoreValue, description))
                {
                    showTable();
                    MessageBox.Show("Score updated successfully");
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Failed to update score");
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_score.DataSource = score.searchScore(textBox_search.Text);
        }
    }
}
