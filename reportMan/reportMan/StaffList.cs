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
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.reportManDataSet.Staff);
            this.CenterToScreen();
            this.Top = 40;
        }
    }
}
