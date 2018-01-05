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
    public partial class PaymentsReport : Form
    {
        public PaymentsReport()
        {
            InitializeComponent();
        }

        private void PaymentsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Bill' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;
            this.reportViewer1.RefreshReport();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
            }
            else
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("You need to pick a session");
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("You need to pick a termn");
                    return;
                }
                this.BillTableAdapter.FillByAllPaymentsReport(this.reportManDataSet.Bill, comboBox1.Text, comboBox2.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to pick a class");
                    return;
                }
                if (comboBox4.Text == "")
                {
                    MessageBox.Show("You need to pick a session");
                    return;
                }
                if (comboBox5.Text == "")
                {
                    MessageBox.Show("You need to pick a term");
                    return;
                }
                this.BillTableAdapter.FillByClassPaymentsReport(this.reportManDataSet.Bill,comboBox4.Text,comboBox5.Text,comboBox3.Text);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
