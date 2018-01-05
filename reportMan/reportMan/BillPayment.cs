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
    public partial class BillPayment : Form
    {
        decimal balance;
        public BillPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dop;
            decimal amountpaid;
            reportManDataSetTableAdapters.BillTableAdapter insBill = new reportManDataSetTableAdapters.BillTableAdapter();
            reportManDataSetTableAdapters.RecieptsTableAdapter insRec = new reportManDataSetTableAdapters.RecieptsTableAdapter();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a class");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select a student name");
                comboBox2.Focus();
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("You need to select a session");
                comboBox3.Focus();
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to select a term");
                comboBox4.Focus();
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the teller number");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter the amount paid");
                textBox2.Focus();
                return;
            }
            dop = (DateTime)dateTimePicker1.Value;
            amountpaid = Convert.ToDecimal(textBox2.Text);
            balance = balance - amountpaid;
           // insBill.InsertQuery("", namess, classs, session, term, DateTime.Today, billamount, 0);
            insBill.InsertQuery(textBox1.Text, comboBox2.Text, comboBox1.Text, comboBox3.Text, comboBox4.Text, dop, 0, amountpaid);
            insRec.InsertQuery(textBox1.Text, comboBox2.Text, comboBox1.Text, comboBox3.Text, comboBox4.Text, dop, balance, amountpaid, "", "", "");
            RecieptsFind rec = new RecieptsFind();
            rec.tellerNumber = textBox1.Text.Trim();
            rec.namess = comboBox2.Text.Trim();
            rec.classs = comboBox1.Text.Trim();
            rec.session = comboBox3.Text.Trim();
            rec.term = comboBox4.Text.Trim();
            rec.dop = dop;
            rec.balance = balance;
            rec.amountpaid = amountpaid;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            label8.Text = "";
           // comboBox1.Focus();
           
            rec.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo, comboBox1.Text);
            comboBox2.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            label8.Text = "";
            comboBox1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            DataTable dtBillAmount, dtAmountPaid;
            decimal TotalAmountPaid, TotalBillAmount;
            reportManDataSetTableAdapters.BillBillAmountTableAdapter BBA = new reportManDataSetTableAdapters.BillBillAmountTableAdapter();
            reportManDataSetTableAdapters.BillAmountPaidTableAdapter BAP = new reportManDataSetTableAdapters.BillAmountPaidTableAdapter();
            dtBillAmount = BBA.GetDataByTotalBillAmount(comboBox2.Text);
            try
            {
                TotalBillAmount = Convert.ToDecimal(dtBillAmount.Rows[0]["TotalBill"].ToString());
            }
            catch
            {
                TotalBillAmount = 0;
            }
            dtAmountPaid = BAP.GetDataByTotalAmountPaid(comboBox2.Text);
            try
            {
                TotalAmountPaid = Convert.ToDecimal(dtAmountPaid.Rows[0]["TotalAmountPaid"].ToString());
            }
            catch
            {
                TotalAmountPaid = 0;
            }
                balance = TotalBillAmount - TotalAmountPaid;
            label8.Text = balance.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
