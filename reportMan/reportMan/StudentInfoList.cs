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
    public partial class StudentInfoList : Form
    {
        public StudentInfoList()
        {
            InitializeComponent();
        }

        private void StudentInfoList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfoList' table. You can move, or remove it, as needed.
            this.StudentInfoListTableAdapter.Fill(this.reportManDataSet.StudentInfoList);
            this.CenterToScreen();
            this.Top = 10;
            this.reportViewer1.RefreshReport();
           
        }
    }
}
