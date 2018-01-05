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
    public partial class InactiveConvention : Form
    {
        public InactiveConvention()
        {
            InitializeComponent();
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.ViewStudents' table. You can move, or remove it, as needed.
           // this.viewStudentsTableAdapter.Fill(this.reportManDataSet.ViewStudents);
            this.viewStudentsTableAdapter.FillBy(this.reportManDataSet.ViewStudents, "CONVENTIONAL", "NO");

            label2.Text = dataGridView1.RowCount.ToString();
            this.CenterToScreen();
            this.Top = 20;
        }
    }
}
