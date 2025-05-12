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
using DGVPrinterHelper;

namespace AppQuanLyHocSinh
{
    public partial class PrinterCourseForm : Form
    {
        DGVPrinter printer = new DGVPrinter();
        CourseClass course = new CourseClass();
        public PrinterCourseForm()
        {
            InitializeComponent();
        }

        public void showTable()
        {
            DataGridView_course.DataSource = course.getCourseList();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = course.searchCourse(textBox_search.Text);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Course List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Course List";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DataGridView_course);
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_course);

        }

        private void PrinterCourseForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
