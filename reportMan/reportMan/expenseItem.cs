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
    public partial class expenseItem : Form
    {
        public expenseItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportManDataSetTableAdapters.ExpenseItemTableAdapter expItem = new reportManDataSetTableAdapters.ExpenseItemTableAdapter();
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the item name");
                textBox1.Focus();
                return;
            }
            expItem.InsertQuery(textBox1.Text);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportManDataSetTableAdapters.ExpenseItemTableAdapter expItem = new reportManDataSetTableAdapters.ExpenseItemTableAdapter();
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the item name");
                textBox1.Focus();
                return;
            }
            expItem.InsertQuery(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();

        }

        private void expenseItem_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Top = 100;
        }
    }
}
