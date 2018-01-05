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
    public partial class AdminChangePassword : Form
    {
        public string myclass;
        int trials;
        public AdminChangePassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter a password");
                textBox1.Focus();
                return;
            }
            DataTable dtte = new DataTable();
            dtte = this.tableADTableAdapter.GetDataBy(textBox1.Text);
            if (dtte.Rows.Count == 0)
            {
                MessageBox.Show("Incorrect Password");
                // trials = + 1;
                trials = trials + 1;

                if (trials == 3)
                {
                    MessageBox.Show("Shutting down ......");
                    this.Close();
                }
                // textBox1.Clear();
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter a new password");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to confirm the new password");
                textBox3.Focus();
                return;
            }
            if (!(textBox2.Text == textBox3.Text))
            {
                MessageBox.Show("Your password and new password don't match");
                textBox2.Clear();
                textBox3.Clear();
                return;
            }
            if (textBox2.Text == textBox3.Text)
            {
                reportManDataSetTableAdapters.TableADTableAdapter agt = new reportManDataSetTableAdapters.TableADTableAdapter();
                agt.UpdateQuery(textBox3.Text);
                MessageBox.Show("Your password has been changed");
                this.Close();
            }
        }

        private void AdminChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.TableAD' table. You can move, or remove it, as needed.
            this.tableADTableAdapter.Fill(this.reportManDataSet.TableAD);
            this.CenterToScreen();
        }
    }
}
