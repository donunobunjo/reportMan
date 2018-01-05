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
    public partial class ItemExpenseReport : Form
    {
        public ItemExpenseReport()
        {
            InitializeComponent();
        }

        private void ItemExpenseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.ExpenseReport' table. You can move, or remove it, as needed.
           // this.ExpenseReportTableAdapter.Fill(this.reportManDataSet.ExpenseReport);
            // TODO: This line of code loads data into the 'reportManDataSet.ExpenseItem' table. You can move, or remove it, as needed.
            this.expenseItemTableAdapter.Fill(this.reportManDataSet.ExpenseItem);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
           // radioButton1.Checked = false;
           //radioButton2.Checked = false;
          // radioButton3.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
           // this.reportViewer1.RefreshReport();
            this.CenterToScreen();
            this.Top = 30;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                groupBox2.Enabled = true;
            }
            else
            {
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                groupBox2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                groupBox1.Enabled = true;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                groupBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    return;
                }
                if (comboBox4.Text == "")
                {
                    MessageBox.Show("You need to select an item");
                    return;
                }
                this.ExpenseReportTableAdapter.FillByItemsTermly(this.reportManDataSet.ExpenseReport, comboBox1.Text, comboBox2.Text, "EXPENSE", comboBox4.Text);
                this.reportViewer1.RefreshReport();
            }
            else if (radioButton2.Checked == true)
            {
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    return;
                }
                if (comboBox4.Text == "")
                {
                    MessageBox.Show("You need to select an item");
                    return;
                }
                // this.ExpenseReportTableAdapter.FillByItemsSession(this.reportManDataSet.ExpenseReport, comboBox3.Text, comboBox4.Text);
                this.ExpenseReportTableAdapter.FillByItemsSession(this.reportManDataSet.ExpenseReport, comboBox3.Text, "EXPENSE", comboBox4.Text);
                this.reportViewer1.RefreshReport();
            }
            else if (radioButton3.Checked == true)
            {
                if (comboBox4.Text == "")
                {
                    MessageBox.Show("You need to select an item");
                    return;
                }
                this.ExpenseReportTableAdapter.FillByAllExpense(this.reportManDataSet.ExpenseReport, "EXPENSE",comboBox4.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("You will need to make a choice! ");
            }
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
