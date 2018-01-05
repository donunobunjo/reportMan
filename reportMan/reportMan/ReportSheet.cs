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
    public partial class ReportSheet : Form
    {
        public ReportSheet()
        {
            InitializeComponent();
        }

        private void ReportSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.ResultReport' table. You can move, or remove it, as needed.
            this.ResultReportTableAdapter.Fill(this.reportManDataSet.ResultReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
