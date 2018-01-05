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
    public partial class NewScholarshipValue : Form
    {
        public NewScholarshipValue()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal scHValue;
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter a scholarship value");
                textBox1.Focus();
                return;
            }
            scHValue = System.Convert.ToDecimal(textBox1.Text);
            this.scholarshipTableAdapter.InsertQuery(scHValue);
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NewScholarshipValue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Scholarship' table. You can move, or remove it, as needed.
            this.scholarshipTableAdapter.Fill(this.reportManDataSet.Scholarship);
            this.CenterToScreen();
            this.Top = 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal scHValue;
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter a scholarship value");
                textBox1.Focus();
                return;
            }
            scHValue = System.Convert.ToDecimal(textBox1.Text);
            this.scholarshipTableAdapter.InsertQuery(scHValue);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
