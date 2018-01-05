using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportMan
{
    public partial class SessionExpenseReport : Form
    {
        public SessionExpenseReport()
        {
            InitializeComponent();
        }

        private void TermlyExpenseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.ExpenseReport' table. You can move, or remove it, as needed.
            //this.ExpenseReportTableAdapter.Fill(this.reportManDataSet.ExpenseReport);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            comboBox1.SelectedIndex = -1;
          //  comboBox2.SelectedIndex = -1;
           // this.reportViewer1.RefreshReport();
            this.CenterToScreen();
            this.Top = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.ExpenseReportTableAdapter.FillByTermly(this.reportManDataSet.ExpenseReport,comboBox1.Text,comboBox2.Text,"EXPENSE");
            this.ExpenseReportTableAdapter.FillBySession(this.reportManDataSet.ExpenseReport, comboBox1.Text, "EXPENSE");
            reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
        }

      

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
