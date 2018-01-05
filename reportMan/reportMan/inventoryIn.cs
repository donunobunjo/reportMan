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
    public partial class inventoryIn : Form
    {
        int quan;
        decimal price;
        decimal amount;
        DateTime transdate;
        reportManDataSetTableAdapters.RevenueExpensesTableAdapter exp = new reportManDataSetTableAdapters.RevenueExpensesTableAdapter();
        reportManDataSetTableAdapters.InventoryTableAdapter inv = new reportManDataSetTableAdapters.InventoryTableAdapter();
        public inventoryIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           textBox2.Text = "";
            comboBox4.SelectedIndex = -1;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a category");
                comboBox1.Focus();
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to select an item");
                comboBox1.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter a supplier name");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("You need to enter quantity");
                textBox4.Focus();
                return;
            }
            quan = Convert.ToInt32(textBox4.Text);
                if (quan<1)
                {
                    MessageBox.Show("Quantity must be a number greater than Zero");
                    textBox4.Focus();
                    return;
                }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter Price of the item");
                textBox2.Focus();
                return;
            }
            price = Convert.ToInt32(textBox2.Text);
            if (price < 0)
            {
                MessageBox.Show("Price must be an amount");
                textBox2.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("You need to enter a reciever name");
                textBox5.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select a session");
                comboBox2.Focus();
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("You need to select a term");
                comboBox3.Focus();
                return;
            }
            transdate = (DateTime)dateTimePicker1.Value;
             quan = Convert.ToInt32(textBox4.Text);
                price = Convert.ToDecimal(textBox2.Text);
                amount = quan * price;
             
                inv.InsertQuery(textBox1.Text, transdate, "", "", textBox5.Text, textBox3.Text, comboBox1.Text, comboBox4.Text, 0, comboBox2.Text, comboBox3.Text, "", price,quan);
                exp.InsertQuery(textBox1.Text, transdate, "", "", "", textBox3.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, "", comboBox4.Text, "EXPENSE", quan, amount, 0, "CASH", "", price);
            this.Close();
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a category");
                comboBox1.Focus();
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to select an item");
                comboBox1.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter a supplier name");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("You need to enter quantity");
                textBox4.Focus();
                return;
            }
            quan = Convert.ToInt32(textBox4.Text);
            if (quan < 1)
            {
                MessageBox.Show("Quantity must be a number greater than Zero");
                textBox4.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter Price of the item");
                textBox2.Focus();
                return;
            }
            price = Convert.ToInt32(textBox2.Text);
            if (price < 0)
            {
                MessageBox.Show("Price must be an amount");
                textBox2.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("You need to enter a reciever name");
                textBox5.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select a session");
                comboBox2.Focus();
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("You need to select a term");
                comboBox3.Focus();
                return;
            }
            transdate = (DateTime)dateTimePicker1.Value;
            quan = Convert.ToInt32(textBox4.Text);
            price = Convert.ToDecimal(textBox2.Text);
            amount = quan * price;

            inv.InsertQuery(textBox1.Text, transdate, "", "", textBox5.Text, textBox3.Text, comboBox1.Text, comboBox4.Text, 0, comboBox2.Text, comboBox3.Text, "", price, quan);
            exp.InsertQuery(textBox1.Text, transdate, "", "", "", textBox3.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, "", comboBox4.Text, "EXPENSE", quan, amount, 0, "CASH", "", price);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox4.SelectedIndex = -1;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox1.Focus();






        }

        private void inventoryIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            // TODO: This line of code loads data into the 'reportManDataSet.InventoryItem' table. You can move, or remove it, as needed.
           // this.inventoryItemTableAdapter.Fill(this.reportManDataSet.InventoryItem);
            this.CenterToScreen();
            this.Top = 10;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inventoryItemTableAdapter.FillByCategory(this.reportManDataSet.InventoryItem, comboBox1.Text);
            comboBox4.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox4.Text);
            }
            catch
            {
                qty = 0;
            }
            amt = unitprice * qty;
            label11.Text = amt.ToString();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox4.Text);
            }
            catch
            {
                qty = 0;
            }
            amt = unitprice * qty;
            label11.Text = amt.ToString();
        }
    }
}
