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
using DGVPrinterHelper;

namespace AppQuanLyHocSinh
{
    public partial class PrintStdForm : Form
    {
        DGVPrinter printer = new DGVPrinter();
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

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM `student`";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM `student` WHERE Gender='Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `student` WHERE Gender='Female'";
            }

            showTable(new MySqlCommand(selectQuery));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Student List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "App Quan Ly Hoc Sinh";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_student);
        }

        private void DataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
