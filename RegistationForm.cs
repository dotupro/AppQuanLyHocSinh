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
    public partial class RegistationForm : Form
    {
        StudentClass student = new StudentClass();
        public RegistationForm()
        {
            InitializeComponent();
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

        private void RegistationForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Select Photo(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(openFile.FileName);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string fName = textBox_fName.Text;
            string lName = textBox_lName.Text;
            DateTime bdate = dateTimePicker_bDate.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";

            int born_year = dateTimePicker_bDate.Value.Year;
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
                    if (student.insertStudent(fName, lName, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_fName.Clear();
            textBox_lName.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker_bDate.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void dateTimePicker_bDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
