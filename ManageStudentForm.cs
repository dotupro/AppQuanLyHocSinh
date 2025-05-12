using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppQuanLyHocSinh
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        bool verify()
        {
            if ((textBox_fName.Text == "") || (textBox_lName.Text == "") || (textBox_phone.Text == "") || (textBox_address.Text == "") || (pictureBox_student.Image == null))
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }

            return true;
        }

        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentList();
            DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView_student.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox_fName.Text = DataGridView_student.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_lName.Text = DataGridView_student.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = DataGridView_student.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (DataGridView_student.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
                radioButton_male.Checked = true;

            textBox_phone.Text = DataGridView_student.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_address.Text = DataGridView_student.Rows[e.RowIndex].Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_student.Rows[e.RowIndex].Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_student.Image = Image.FromStream(ms);
        }

        private void button_clearManaStd_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_fName.Clear();
            textBox_lName.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Photo(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(openFile.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_student.DataSource = student.searchDtudent(textBox_search.Text);
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            string fName = textBox_fName.Text;
            string lName = textBox_lName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Student must be between 10 to 100 years old", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.updateStudent(id, fName, lName, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Student update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "")
                {
                    MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = Convert.ToInt32(textBox_id.Text);

                if (MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        showTable();
                        MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clearManaStd_Click(null, null); // Clear fields after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
