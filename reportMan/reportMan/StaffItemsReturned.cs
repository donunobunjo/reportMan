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
    public partial class StaffItemsReturned : Form
    {
        public StaffItemsReturned()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffItemsRecieved_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StaffInventory' table. You can move, or remove it, as needed.
            this.staffInventoryTableAdapter.Fill(this.reportManDataSet.StaffInventory);
            // TODO: This line of code loads data into the 'reportManDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.reportManDataSet.Staff);
            comboBox1.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 30;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to pick the staff name");
                comboBox1.Focus();
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the item the staff is recieving");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter the quantity");
                textBox1.Focus();
                return;
            }
            if (System.Convert.ToDecimal(textBox2.Text) < 1)
            {
                MessageBox.Show("You need to enter a quantity greater than 0");
                textBox2.Focus();
                return;
            }
            int qty;
            DateTime DOT;
            qty = System.Convert.ToInt32(textBox2.Text);
            DOT = (DateTime)dateTimePicker1.Value;
            this.staffInventoryTableAdapter.InsertQuery(comboBox1.Text, textBox1.Text, 0, qty, textBox3.Text, DOT);
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to pick the staff name");
                comboBox1.Focus();
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the item the staff is recieving");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter the quantity");
                textBox1.Focus();
                return;
            }
            if (System.Convert.ToDecimal(textBox2.Text) < 1)
            {
                MessageBox.Show("You need to enter a quantity greater than 0");
                textBox2.Focus();
                return;
            }
            int qty;
            DateTime DOT;
            qty = System.Convert.ToInt32(textBox2.Text);
            DOT = (DateTime)dateTimePicker1.Value;
            this.staffInventoryTableAdapter.InsertQuery(comboBox1.Text, textBox1.Text, 0,qty, textBox3.Text, DOT);
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
