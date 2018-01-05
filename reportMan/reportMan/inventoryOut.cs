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
    public partial class inventoryOut : Form
    {
        reportManDataSetTableAdapters.RevenueExpensesTableAdapter rev = new reportManDataSetTableAdapters.RevenueExpensesTableAdapter();
        string admissionNumber, studentName;
        DateTime dot;
        DataTable dt = new DataTable();
        reportManDataSetTableAdapters.StudentInfoTableAdapter studInfo = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
        reportManDataSetTableAdapters.InventoryTableAdapter inv = new reportManDataSetTableAdapters.InventoryTableAdapter();
        int quan;
        decimal price;
        decimal amount;
        public inventoryOut()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           textBox2.Text = "";
            comboBox4.SelectedIndex = -1;
            //textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
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
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            textBox5.Enabled = false;
            comboBox5.Enabled = false;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a category");
                comboBox1.Focus();
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to select an item");
                comboBox1.Focus();
                return;
            }
            if (comboBox1.Text == "UNIFORMS" || comboBox1.Text == "BOOKS")
            {
                if (comboBox5.Text == "")
                {
                    MessageBox.Show("You need to select a class");
                    comboBox5.Focus();
                    return;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("You need to select a student name or a student number");
                    return;
                }
                if (radioButton1.Checked == true && comboBox6.Text == "")
                {
                    MessageBox.Show("You need to select a student admission number");
                    comboBox6.Focus();
                    return;
                }
                if (radioButton2.Checked == true && comboBox7.Text == "")
                {
                    MessageBox.Show("You need to select a student name");
                    comboBox7.Focus();
                    return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("You need to enter quantity");
                    textBox4.Focus();
                    return;
                }
                quan = Convert.ToInt32(textBox4.Text);
                if (quan < 1)
                {
                    MessageBox.Show("Quantity must be a number greater than Zero");
                    textBox4.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("You need to enter Price of the item");
                    textBox2.Focus();
                    return;
                }
                price = Convert.ToDecimal(textBox2.Text);
                if (price < 0)
                {
                    MessageBox.Show("Price must be an amount");
                    textBox2.Focus();
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox2.Focus();
                    return;
                }
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox3.Focus();
                    return;
                }
                if (radioButton1.Checked == true)
                {
                    admissionNumber = comboBox6.Text;
                    dt = studInfo.GetDataByAdminNumber(admissionNumber);
                    studentName = dt.Rows[0][4].ToString();
                    //dt.Rows[0][4].ToString();
                }
                if (radioButton2.Checked == true)
                {
                    studentName = comboBox7.Text;
                    dt = studInfo.GetDataByFullname(studentName);
                    admissionNumber = dt.Rows[0][0].ToString();
                }
                dot = (DateTime)dateTimePicker1.Value;
                amount = quan * price;
                inv.InsertQuery(textBox1.Text, dot, admissionNumber, studentName, textBox5.Text, "", comboBox1.Text, comboBox4.Text, quan, comboBox2.Text, comboBox3.Text, comboBox5.Text, price, 0);
                rev.InsertQuery(textBox1.Text, dot, studentName, admissionNumber, "", "", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, comboBox4.Text, "REVENUE", quan, 0, amount, "CASH", "", price);
            }
            else
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("You need to enter quantity");
                    textBox4.Focus();
                    return;
                }
                quan = Convert.ToInt32(textBox4.Text);
                if (quan < 1)
                {
                    MessageBox.Show("Quantity must be a number greater than Zero");
                    textBox4.Focus();
                    return;
                }

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox2.Focus();
                    return;
                }
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox3.Focus();
                    return;
                }

                dot = (DateTime)dateTimePicker1.Value;
                amount = quan * price;
                inv.InsertQuery(textBox1.Text, dot, "", "", textBox5.Text, "", comboBox1.Text, comboBox4.Text, quan, comboBox2.Text, comboBox3.Text, "", price, 0);
                // rev.InsertQuery(textBox1.Text, dot, "", "", "", "", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, comboBox4.Text, "REVENUE", quan, 0, amount, "CASH", "", price);
            }
            this.Close();

        }



            
      /*          if (textBox5.Enabled && textBox5.Text == "")
                {
                    MessageBox.Show("You need to enter a reciever name");
                    textBox5.Focus();
                    return; 
                }
            
            if (textBox4.Text == "")
            {
                MessageBox.Show("You need to enter quantity");
                textBox4.Focus();
                return;
            }
            quan = Convert.ToInt32(textBox4.Text);
            if (quan < 1)
            {
                MessageBox.Show("Quantity must be a number greater than Zero");
                textBox4.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter Price of the item");
                textBox2.Focus();
                return;
            }
            price = Convert.ToDecimal(textBox2.Text);
            if (price < 0)
            {
                MessageBox.Show("Price must be an amount");
                textBox2.Focus();
                return;
            }
           
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select a session");
                comboBox2.Focus();
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("You need to select a term");
                comboBox3.Focus();
                return;
            }
            if (radioButton1.Checked == true)
            {
                admissionNumber = comboBox6.Text;
                dt = studInfo.GetDataByAdminNumber(admissionNumber);
                studentName = dt.Rows[0][4].ToString();
                //dt.Rows[0][4].ToString();
            }
            if (radioButton2.Checked == true)
            {
                studentName = comboBox7.Text;
                dt = studInfo.GetDataByFullname(studentName);
                admissionNumber = dt.Rows[0][0].ToString();
            }
            dot = (DateTime)dateTimePicker1.Value;
            inv.InsertQuery(textBox1.Text, dot, admissionNumber, studentName, textBox5.Text, "", comboBox1.Text, comboBox4.Text, quan, comboBox2.Text, comboBox3.Text, comboBox5.Text, price,0);
            MessageBox.Show("lalala");
        }*/

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a category");
                comboBox1.Focus();
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to select an item");
                comboBox1.Focus();
                return;
            }
            if (comboBox1.Text == "UNIFORMS" || comboBox1.Text == "BOOKS")
            {
                if (comboBox5.Text == "")
                {
                    MessageBox.Show("You need to select a class");
                    comboBox5.Focus();
                    return;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("You need to select a student name or a student number");
                    return;
                }
                if (radioButton1.Checked == true && comboBox6.Text == "")
                {
                    MessageBox.Show("You need to select a student admission number");
                    comboBox6.Focus();
                    return;
                }
                if (radioButton2.Checked == true && comboBox7.Text == "")
                {
                    MessageBox.Show("You need to select a student name");
                    comboBox7.Focus();
                    return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("You need to enter quantity");
                    textBox4.Focus();
                    return;
                }
                quan = Convert.ToInt32(textBox4.Text);
                if (quan < 1)
                {
                    MessageBox.Show("Quantity must be a number greater than Zero");
                    textBox4.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("You need to enter Price of the item");
                    textBox2.Focus();
                    return;
                }
                price = Convert.ToDecimal(textBox2.Text);
                if (price < 0)
                {
                    MessageBox.Show("Price must be an amount");
                    textBox2.Focus();
                    return;
                }
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox2.Focus();
                    return;
                }
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox3.Focus();
                    return;
                }
                if (radioButton1.Checked == true)
                {
                    admissionNumber = comboBox6.Text;
                    dt = studInfo.GetDataByAdminNumber(admissionNumber);
                    studentName = dt.Rows[0][4].ToString();
                    //dt.Rows[0][4].ToString();
                }
                if (radioButton2.Checked == true)
                {
                    studentName = comboBox7.Text;
                    dt = studInfo.GetDataByFullname(studentName);
                    admissionNumber = dt.Rows[0][0].ToString();
                }
                dot = (DateTime)dateTimePicker1.Value;
                amount = quan * price;
                inv.InsertQuery(textBox1.Text, dot, admissionNumber, studentName, textBox5.Text, "", comboBox1.Text, comboBox4.Text, quan, comboBox2.Text, comboBox3.Text, comboBox5.Text, price, 0);
                rev.InsertQuery(textBox1.Text, dot, studentName, admissionNumber, "", "", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, comboBox4.Text, "REVENUE", quan, 0, amount, "CASH", "", price);
            }
            else
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("You need to enter quantity");
                    textBox4.Focus();
                    return;
                }
                quan = Convert.ToInt32(textBox4.Text);
                if (quan < 1)
                {
                    MessageBox.Show("Quantity must be a number greater than Zero");
                    textBox4.Focus();
                    return;
                }

                if (comboBox2.Text == "")
                {
                    MessageBox.Show("You need to select a session");
                    comboBox2.Focus();
                    return;
                }
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("You need to select a term");
                    comboBox3.Focus();
                    return;
                }

                dot = (DateTime)dateTimePicker1.Value;
                amount = quan * price;
                inv.InsertQuery(textBox1.Text, dot, "", "", textBox5.Text, "", comboBox1.Text, comboBox4.Text, quan, comboBox2.Text, comboBox3.Text, "", price, 0);
                // rev.InsertQuery(textBox1.Text, dot, "", "", "", "", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, comboBox4.Text, "REVENUE", quan, 0, amount, "CASH", "", price);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox4.SelectedIndex = -1;
            //textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
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
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            textBox5.Enabled = false;
            comboBox5.Enabled = false;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox6.Enabled = true;
                comboBox7.Enabled = false;
            }
            else
            {
                comboBox6.Enabled = false;
                comboBox7.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox7.Enabled = true;
                comboBox6.Enabled = false;
            }
            else
            {
                comboBox7.Enabled = false;
                comboBox6.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            if (comboBox1.Text == "UNIFORMS" || comboBox1.Text == "BOOKS")
            {
                groupBox2.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                comboBox5.Enabled = true;
                textBox5.Enabled = false;
                comboBox5.SelectedIndex = -1;
            }
            else
            {
                groupBox2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                comboBox5.Enabled = false;
                textBox5.Enabled = true;
                textBox2.Enabled = false;
            }
            this.inventoryItemTableAdapter.FillByCategory(this.reportManDataSet.InventoryItem,comboBox1.Text);
            comboBox4.SelectedIndex = -1;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void inventoryOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo1' table. You can move, or remove it, as needed.
           // this.studentInfo1TableAdapter.Fill(this.reportManDataSet.StudentInfo1);
            // TODO: This line of code loads data into the 'reportManDataSet.InventoryItem' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            comboBox2.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 10;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo,comboBox5.Text);
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
             decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox4.Text);
            }
            catch
            {
                qty = 0;
            }
            amt = unitprice * qty;
            label12.Text = amt.ToString();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            decimal unitprice;
            decimal qty;
            decimal amt;
            try
            {
                unitprice = System.Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                unitprice = 0;
            }
            try
            {
                qty = System.Convert.ToDecimal(textBox4.Text);
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
