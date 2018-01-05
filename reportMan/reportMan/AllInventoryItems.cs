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
    public partial class AllInventoryItems : Form
    {
        public AllInventoryItems()
        {
            InitializeComponent();
        }

        private void AllInventoryItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.InventoryItem' table. You can move, or remove it, as needed.
            this.inventoryItemTableAdapter.Fill(this.reportManDataSet.InventoryItem);
            this.CenterToScreen();
            this.Top = 20;
        }
    }
}
