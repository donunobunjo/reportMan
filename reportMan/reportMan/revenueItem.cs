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
    public partial class revenueItem : Form
    {
        reportManDataSetTableAdapters.RevenueItemTableAdapter revitem = new reportManDataSetTableAdapters.RevenueItemTableAdapter();

        public revenueItem()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select an item category");
                comboBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter the item name");
                textBox2.Focus();
                return;
            }
            revitem.InsertQuery(comboBox1.Text, textBox2.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select an item category");
                comboBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter the item name");
                textBox2.Focus();
                return;
            }
            revitem.InsertQuery(comboBox1.Text, textBox2.Text);
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
            comboBox1.Focus();
        }

        private void revenueItem_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Top = 100;
        }
    }
}
