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
    public partial class AllExpenseItems : Form
    {
        public AllExpenseItems()
        {
            InitializeComponent();
        }

        private void AllExpenseItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.ExpenseItem' table. You can move, or remove it, as needed.
            this.expenseItemTableAdapter.Fill(this.reportManDataSet.ExpenseItem);
            this.CenterToScreen();
            this.Top = 20;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
