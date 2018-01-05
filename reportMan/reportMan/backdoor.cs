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
    public partial class backdoor : Form
    {
        public string myclass;
        public backdoor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == textBox2.Text))
            {
                MessageBox.Show("Your password and new password don't match");
                textBox1.Clear();
                textBox2.Clear();
                return;
            }
            if (textBox1.Text == textBox2.Text)
            {
                reportManDataSetTableAdapters.TableADTableAdapter agt = new reportManDataSetTableAdapters.TableADTableAdapter();
                agt.UpdateQuery(textBox2.Text);
                MessageBox.Show("Your password has been changed");
                this.Close();
            }
        }

        private void backdoor_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
