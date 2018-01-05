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
    public partial class StaffInfo : Form
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.reportManDataSet.Staff);
            this.CenterToScreen();
            this.Top = 50;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter staff full names");
                textBox1.Focus();
                return;
            }
            this.staffTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter staff full names");
                textBox1.Focus();
                return;
            }
            this.staffTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
