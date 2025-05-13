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
    public partial class PrinterScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
        public PrinterScoreForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_score.DataSource = score.searchScore(textBox_search.Text);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Score List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Score List";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(DataGridView_score);
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_score);
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            DataGridView_score.DataSource = score.getScoreList();
        }
    }
}
