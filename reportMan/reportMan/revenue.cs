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
    public partial class revenue : Form
    {
        int quan;
        decimal price;
        decimal amount;
        DateTime transdate;
        String theclass;
        reportManDataSetTableAdapters.RevenueExpensesTableAdapter rev = new reportManDataSetTableAdapters.RevenueExpensesTableAdapter();
        string admissionNumber, studentName;
        public revenue()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox4.Enabled = true;
                comboBox5.Enabled = false;
                comboBox4.SelectedIndex = -1;
            }
            else
            {
                comboBox4.Enabled = false;
                comboBox5.Enabled = true;
                comboBox5.SelectedIndex = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox4.SelectedIndex = -1;
            //textBox3.Text = "";
           comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
           // comboBox5.Enabled = false;
            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox2.Text = "";
            if (comboBox1.Text == "EXT. EXAMS")
            {
                groupBox1.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                comboBox3.Enabled = true;
               // textBox5.Enabled = false;
                comboBox3.SelectedIndex = -1;
            }
            else
            {
                groupBox1.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                comboBox3.Enabled = false;
               // textBox5.Enabled = true;
            }
            if (comboBox1.Text == "PTA" || comboBox1.Text == "OTHERS")
            {
                groupBox1.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                comboBox3.Enabled = false;
                textBox2.Enabled = false;
            }
            this.revenueItemTableAdapter.FillBycATEGORY(this.reportManDataSet.RevenueItem, comboBox1.Text);
            comboBox2.SelectedIndex = -1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox5.Enabled = true;
                comboBox4.Enabled = false;
                comboBox5.SelectedIndex = -1;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox4.Enabled = true;
                comboBox4.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            reportManDataSetTableAdapters.StudentInfoTableAdapter studInfo = new reportManDataSetTableAdapters.StudentInfoTableAdapter();

            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a category");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select an item");
                comboBox2.Focus();
                return;
            }
            if (comboBox1.Text == "EXT. EXAMS")
            {
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a class");
                    comboBox3.Focus();
                    return;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("You need to select a student name or number");
                    return;
                }
                if (radioButton1.Checked && comboBox4.Text == "")
                {
                    MessageBox.Show("You need to select a student admission number");
                    comboBox4.Focus();
                    return;
                }
                if (radioButton2.Checked && comboBox5.Text == "")
                {
                    MessageBox.Show("You need to select a student name");
                    comboBox5.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("You need to enter a quantity");
                    textBox2.Focus();
                    return;
                }
                if (System.Convert.ToDecimal(textBox2.Text) < 1)
                {
                    MessageBox.Show("You need to enter a quantity greater than 0");
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("You need to enter a price");
                    textBox3.Focus();
                    return;
                }
                if (System.Convert.ToDecimal(textBox3.Text) < 1)
                {
                    MessageBox.Show("You need to enter a price greater than 0");
                    textBox3.Focus();
                    return;
                }
                if (comboBox6.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox6.Focus();
                    return;
                }
                if (comboBox7.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox7.Focus();
                    return;
                }
                if (radioButton1.Checked == true)
                {
                    admissionNumber = comboBox4.Text;
                    dt = studInfo.GetDataByAdminNumber(admissionNumber);
                    studentName = dt.Rows[0][4].ToString();
                    //dt.Rows[0][4].ToString();
                }
                if (radioButton2.Checked == true)
                {
                    studentName = comboBox5.Text;
                    dt = studInfo.GetDataByFullname(studentName);
                    admissionNumber = dt.Rows[0][0].ToString();
                }
                transdate = (DateTime)dateTimePicker1.Value;

                quan = Convert.ToInt32(textBox2.Text);
                price = Convert.ToDecimal(textBox3.Text);
                amount = quan * price;
                rev.InsertQuery(textBox1.Text, transdate, studentName, admissionNumber, "", "", comboBox1.Text, comboBox6.Text, comboBox7.Text, comboBox3.Text, comboBox2.Text, "REVENUE", quan, 0, amount, "CASH", textBox4.Text, price);
            }





            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "PTA" || comboBox1.Text == "OTHERS")
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("You need to amount in the price field");
                    textBox3.Focus();
                    return;
                }
                if (System.Convert.ToDecimal(textBox3.Text) < 1)
                {
                    MessageBox.Show("You need to enter an amount greater than 0");
                    textBox3.Focus();
                    return;
                }
                if (comboBox6.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox6.Focus();
                    return;
                }
                if (comboBox7.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox7.Focus();
                    return;
                }
                transdate = (DateTime)dateTimePicker1.Value;

                quan = 1;
                price = Convert.ToDecimal(textBox3.Text);
                amount = quan * price;
                // rev.InsertQuery(textBox1.Text, transdate, studentName, admissionNumber, "", "", comboBox1.Text, comboBox6.Text, comboBox7.Text, comboBox3.Text, comboBox2.Text, "REVENUE", quan, 0, amount, "CASH", textBox4.Text, price);
                rev.InsertQuery(textBox1.Text, transdate, "", "", "", "", comboBox1.Text, comboBox6.Text, comboBox7.Text, "", comboBox2.Text, "REVENUE", quan, 0, amount, "CASH", textBox4.Text, price);
            }
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            reportManDataSetTableAdapters.StudentInfoTableAdapter studInfo = new reportManDataSetTableAdapters.StudentInfoTableAdapter();

            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a category");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select an item");
                comboBox2.Focus();
                return;
            }
            if (comboBox1.Text == "EXT. EXAMS")
            {
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a class");
                    comboBox3.Focus();
                    return;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("You need to select a student name or number");
                    return;
                }
                if (radioButton1.Checked && comboBox4.Text == "")
                {
                    MessageBox.Show("You need to select a student admission number");
                    comboBox4.Focus();
                    return;
                }
                if (radioButton2.Checked && comboBox5.Text == "")
                {
                    MessageBox.Show("You need to select a student name");
                    comboBox5.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("You need to enter a quantity");
                    textBox2.Focus();
                    return;
                }
                if (System.Convert.ToDecimal(textBox2.Text) < 1)
                {
                    MessageBox.Show("You need to enter a quantity greater than 0");
                    textBox2.Focus();
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("You need to enter a price");
                    textBox3.Focus();
                    return;
                }
                if (System.Convert.ToDecimal(textBox3.Text) < 1)
                {
                    MessageBox.Show("You need to enter a price greater than 0");
                    textBox3.Focus();
                    return;
                }
                if (comboBox6.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox6.Focus();
                    return;
                }
                if (comboBox7.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox7.Focus();
                    return;
                }
                if (radioButton1.Checked == true)
                {
                    admissionNumber = comboBox4.Text;
                    dt = studInfo.GetDataByAdminNumber(admissionNumber);
                    studentName = dt.Rows[0][4].ToString();
                    //dt.Rows[0][4].ToString();
                }
                if (radioButton2.Checked == true)
                {
                    studentName = comboBox5.Text;
                    dt = studInfo.GetDataByFullname(studentName);
                    admissionNumber = dt.Rows[0][0].ToString();
                }
                transdate = (DateTime)dateTimePicker1.Value;

                quan = Convert.ToInt32(textBox2.Text);
                price = Convert.ToDecimal(textBox3.Text);
                amount = quan * price;
                rev.InsertQuery(textBox1.Text, transdate, studentName, admissionNumber, "", "", comboBox1.Text, comboBox6.Text, comboBox7.Text, comboBox3.Text, comboBox2.Text, "REVENUE", quan, 0, amount, "CASH", textBox4.Text, price);
            }





            ///////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "PTA" || comboBox1.Text == "OTHERS")
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("You need to amount in the price field");
                    textBox3.Focus();
                    return;
                }
                if (System.Convert.ToDecimal(textBox3.Text) < 1)
                {
                    MessageBox.Show("You need to enter an amount greater than 0");
                    textBox3.Focus();
                    return;
                }
                if (comboBox6.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox6.Focus();
                    return;
                }
                if (comboBox7.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox7.Focus();
                    return;
                }
                transdate = (DateTime)dateTimePicker1.Value;

                quan = 1;
                price = Convert.ToDecimal(textBox3.Text);
                amount = quan * price;
                // rev.InsertQuery(textBox1.Text, transdate, studentName, admissionNumber, "", "", comboBox1.Text, comboBox6.Text, comboBox7.Text, comboBox3.Text, comboBox2.Text, "REVENUE", quan, 0, amount, "CASH", textBox4.Text, price);
                rev.InsertQuery(textBox1.Text, transdate, "", "", "", "", comboBox1.Text, comboBox6.Text, comboBox7.Text, "", comboBox2.Text, "REVENUE", quan, 0, amount, "CASH", textBox4.Text, price);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox4.SelectedIndex = -1;
            //textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            // comboBox5.Enabled = false;
            textBox1.Focus();
        }

        private void revenue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.RevenueItem' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            this.CenterToScreen();
            this.Top = 10;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo,comboBox3.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox3.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                qty = 0;
            }
            amt = unitprice * qty;
            label12.Text = amt.ToString();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox3.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                qty = 0;
            }
            amt = unitprice * qty;
            label12.Text = amt.ToString();

        }
    }
}
