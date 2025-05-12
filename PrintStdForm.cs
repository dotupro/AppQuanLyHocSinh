using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppQuanLyHocSinh
{
    public partial class PrintStdForm : Form
    {
        public PrintStdForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PrintStdForm_Load(object sender, EventArgs e)
        {
            showTable(new MySqlCommand("SELECT * FROM `student`"));
        }

        public void showTable(MySqlCommand command)
        {
            DataGridView_student.ReadOnly = true;
            StudentClass student = new StudentClass();
            DataGridView_student.DataSource = student.getList(command);
            DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
