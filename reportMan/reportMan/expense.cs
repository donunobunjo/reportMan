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
    public partial class expense : Form
    {
        reportManDataSetTableAdapters.RevenueExpensesTableAdapter exp = new reportManDataSetTableAdapters.RevenueExpensesTableAdapter();
        DateTime DOT;
        public expense()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quan;
            decimal price;
            decimal amount;
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to pick an expense item");
                comboBox2.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter quantity");
                textBox2.Focus();
                return;
            }
            quan = Convert.ToInt32(textBox2.Text);
            if (quan < 1)
            {
                MessageBox.Show("Quantity must be a number greater than Zero");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter Price of the item");
                textBox3.Focus();
                return;
            }
            price = Convert.ToDecimal(textBox3.Text);
            if (price < 1)
            {
                MessageBox.Show("Price must be a amount greater than Zero");
                textBox3.Focus();
                return;
            }
            if (comboBox6.Text == "")
            {
                MessageBox.Show("You need to select a session");
                comboBox6.Focus();
                return;
            }
            if (comboBox7.Text == "")
            {
                MessageBox.Show("You need to select a term");
                comboBox7.Focus();
                return;
            }
            amount = price * quan;
            DOT =  (DateTime)dateTimePicker1.Value;
            exp.InsertQuery(textBox1.Text, DOT, "", "", "", "", "", comboBox6.Text, comboBox7.Text, "", comboBox2.Text, "EXPENSE", quan, amount, 0, "CASH", textBox4.Text, price);
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quan;
            decimal price;
            decimal amount;
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to pick an expense item");
                comboBox2.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter quantity");
                textBox2.Focus();
                return;
            }
            quan = Convert.ToInt32(textBox2.Text);
            if (quan < 1)
            {
                MessageBox.Show("Quantity must be a number greater than Zero");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter Price of the item");
                textBox3.Focus();
                return;
            }
            price = Convert.ToDecimal(textBox3.Text);
            if (price < 1)
            {
                MessageBox.Show("Price must be a amount greater than Zero");
                textBox3.Focus();
                return;
            }
            if (comboBox6.Text == "")
            {
                MessageBox.Show("You need to select a session");
                comboBox6.Focus();
                return;
            }
            if (comboBox7.Text == "")
            {
                MessageBox.Show("You need to select a term");
                comboBox7.Focus();
                return;
            }
            amount = price * quan;
            DOT = (DateTime)dateTimePicker1.Value;
            exp.InsertQuery(textBox1.Text, DOT, "", "", "", "", "", comboBox6.Text, comboBox7.Text, "", comboBox2.Text, "EXPENSE", quan, amount, 0, "CASH", textBox4.Text, price);
           // this.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
           
            // TODO: This line of code loads data into the 'reportManDataSet.ExpenseItem' table. You can move, or remove it, as needed.
            this.expenseItemTableAdapter.Fill(this.reportManDataSet.ExpenseItem);
            comboBox2.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 20;
        }

       
        
              private void textBox3_Leave(object sender, EventArgs e)
        {
            decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox3.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                qty = 0;
            }
            amt = unitprice * qty;
            label8.Text = amt.ToString();

        
        }

              private void textBox2_Leave(object sender, EventArgs e)
              {
                  decimal unitprice;
                  decimal qty;
                  decimal amt;
                  try
                  {
                      unitprice = System.Convert.ToDecimal(textBox3.Text);
                  }
                  catch
                  {
                      unitprice = 0;
                  }
                  try
                  {
                      qty = System.Convert.ToDecimal(textBox2.Text);
                  }
                  catch
                  {
                      qty = 0;
                  }
                  amt = unitprice * qty;
                  label8.Text = amt.ToString();
              }
    }
}
