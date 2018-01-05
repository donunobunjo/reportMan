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
    public partial class SessionRevenueReport : Form
    {
        public SessionRevenueReport()
        {
            InitializeComponent();
        }

        private void SessionRevenueReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.RevenueReport' table. You can move, or remove it, as needed.
          // this.RevenueReportTableAdapter.Fill(this.reportManDataSet.RevenueReport);
            // TODO: This line of code loads data into the 'reportManDataSet.RevenueReport' table. You can move, or remove it, as needed.
          //this.RevenueReportTableAdapter.Fill(this.reportManDataSet.RevenueReport);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
           this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            //
           comboBox1.SelectedIndex = -1;
         // this.reportViewer1.RefreshReport();
           this.CenterToScreen();
           this.Top = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RevenueReportTableAdapter.FillBySession(this.reportManDataSet.RevenueReport, comboBox1.Text, "REVENUE");
            this.reportViewer1.RefreshReport();
        }
    }
}
