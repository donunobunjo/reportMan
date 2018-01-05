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
    public partial class StaffInventoryReport : Form
    {
        public StaffInventoryReport()
        {
            InitializeComponent();
        }

        private void StaffInventoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StaffInventory' table. You can move, or remove it, as needed.
          //  this.StaffInventoryTableAdapter.Fill(this.reportManDataSet.StaffInventory);
            // TODO: This line of code loads data into the 'reportManDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.reportManDataSet.Staff);
            comboBox1.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = -10;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StaffInventoryTableAdapter.FillByStaffName(this.reportManDataSet.StaffInventory, comboBox1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
