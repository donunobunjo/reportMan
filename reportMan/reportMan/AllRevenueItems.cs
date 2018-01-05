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
    public partial class AllRevenueItems : Form
    {
        public AllRevenueItems()
        {
            InitializeComponent();
        }

        private void AllRevenueItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.RevenueItem' table. You can move, or remove it, as needed.
            this.revenueItemTableAdapter.Fill(this.reportManDataSet.RevenueItem);
            this.CenterToScreen();
            this.Top = 50;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
