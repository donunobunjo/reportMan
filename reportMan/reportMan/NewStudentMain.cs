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
    public partial class NewStudentMain : Form
    {
        Boolean activemain;
        string filepath;
        string fullname;
        DateTime dob;
        DateTime doe;
        string active;
        public NewStudentMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
           
        {
            
            reportManDataSetTableAdapters.StudentInfoTableAdapter insstudent = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
           /* if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the student's admission number number");
                textBox1.Focus();
                return;
            }*/
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter student's surname");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter student's first name");
                textBox3.Focus();
                return;
            }
          /*  if (textBox4.Text == "")
            {
                MessageBox.Show("You need to enter student's other names");
                textBox4.Focus();
                return;
            }*/
            /*if (comboBox7.Text == "")
            {
                MessageBox.Show("You need to pick a scholarship type");
                
                comboBox7.Focus();
                return;
            }*/
            if (comboBox9.Text == "")
            {
                MessageBox.Show("You need to pick the student school i.e ACE or CONVENTIONAL");

                comboBox9.Focus();
                return;
            }
            if (comboBox5.Text == "")
            {
                MessageBox.Show("You need to pick a gendre");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                // tabControl1.SelectedTab = tabPage2;
                comboBox5.Focus();
                return;
            }
            if (comboBox6.Text == "")
            {
                MessageBox.Show("You need to pick a class for the student");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                // tabControl1.SelectedTab = tabPage2;
                comboBox6.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian full names");
                // textBox4.Focus();
               // this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox5.Focus();
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian office number");
                // textBox4.Focus();
                //this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox6.Focus();
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian home number");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox7.Focus();
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian addresss");
                // textBox4.Focus();
               // this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox9.Focus();
                return;
            }
            if (checkBox1.Checked == true)
            {
                active = "YES";
                activemain = true;
            }
            else
            {
                active = "NO";
                activemain = false;
            }
            fullname = textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;

            DataTable mydt = new DataTable();
            mydt = this.studentInfoTableAdapter.GetDataByStudentExistence(fullname);
            if (mydt.Rows.Count != 0)
            {
                MessageBox.Show("Student with this names already exists in the database, you might consider changing the other names field");
                textBox4.Focus();
                return;

            }

            dob = (DateTime)dateTimePicker1.Value;
            doe = (DateTime)dateTimePicker2.Value;
            if (filepath =="C:\\reportMAN\\StudentPassport\\blank.jpg");
            {
            DialogResult reslt = MessageBox.Show("You did not include the student passport, if you don't include it now, you will not be able to include it in the future.Will you want to include a passport? Then click the BROWSE FOR PASSPORT BUTTON","Do you want to include a passport?",MessageBoxButtons.YesNo);
           
            if (reslt == DialogResult.No)
            {
           
           //insstudent.InsertQuery(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, fullname, comboBox1.Text, comboBox2.Text, textBox5.Text, textBox9.Text, textBox6.Text, textBox7.Text, textBox8.Text, comboBox5.Text, comboBox3.Text, comboBox4.Text, comboBox6.Text,active,dob,filepath);
                insstudent.InsertQuery(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, fullname, comboBox1.Text, comboBox2.Text, textBox5.Text, textBox9.Text, textBox6.Text, textBox7.Text, textBox8.Text, comboBox5.Text, comboBox3.Text, comboBox4.Text, comboBox6.Text, active, dob, filepath, comboBox7.Text, textBox12.Text, textBox10.Text, activemain, comboBox8.Text, doe, comboBox9.Text, textBox11.Text);
            // MessageBox.Show("database updated");
           this.Close();
            }
            else
            {
                if (opfil.ShowDialog() != DialogResult.OK)
                { return; }
                opfil.ShowDialog();
                filepath = opfil.FileName;
                pictureBox1.Load(filepath);
            }
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opfil.ShowDialog() != DialogResult.OK)
            { return; }
           //gk opfil.ShowDialog();
            filepath = opfil.FileName;
            pictureBox1.Load(filepath);
        }

        private void NewStudentMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Scholarship' table. You can move, or remove it, as needed.
            this.scholarshipTableAdapter.Fill(this.reportManDataSet.Scholarship);
            // TODO: This line of code loads data into the 'reportManDataSet.States' table. You can move, or remove it, as needed.
           // this.statesTableAdapter.Fill(this.reportManDataSet.States);
            // TODO: This line of code loads data into the 'reportManDataSet.distinctStates' table. You can move, or remove it, as needed.
            this.distinctStatesTableAdapter.Fill(this.reportManDataSet.distinctStates);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            //this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            filepath = @"C:\reportMAN\StudentPassport\blank.jpg";
            pictureBox1.Load(filepath);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            this.CenterToScreen();

            this.Top = 1;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportManDataSetTableAdapters.StudentInfoTableAdapter insstudent = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
            /*if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the student's admission number number");
                textBox1.Focus();
             * 
                return;
            }*/
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter student's surname");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter student's first name");
                textBox3.Focus();
                return;
            }
           /* if (textBox4.Text == "")
            {
                MessageBox.Show("You need to enter student's other names");
                textBox4.Focus();
                return;
            }*/
            if (comboBox5.Text == "")
            {
                MessageBox.Show("You need to pick a gendre");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                // tabControl1.SelectedTab = tabPage2;
                comboBox5.Focus();
                return;
            }
          /*  if (comboBox6.Text == "")
            {
                MessageBox.Show("You need to pick a class for the student");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                // tabControl1.SelectedTab = tabPage2;
                comboBox6.Focus();
                return;
            }*/
            if (comboBox8.Text == "")
            {
                MessageBox.Show("You need to pick a religion");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                // tabControl1.SelectedTab = tabPage2;
                comboBox8.Focus();
                return;
            }
           /* if (comboBox9.Text == "")
            {
                MessageBox.Show("You need to pick the student school i.e ACE or CONVENTIONAL");

                comboBox9.Focus();
                return;
            }*/
            if (textBox5.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian full names");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox5.Focus();
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian office number");
                // textBox4.Focus();
                //this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox6.Focus();
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian home number");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox7.Focus();
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("You need to enter Parent/Guardian addresss");
                // textBox4.Focus();
                // this.tabControl1.TabPages[1].Focus();
                tabControl1.SelectedTab = tabPage2;
                textBox9.Focus();
                return;
            }
             if (checkBox1.Checked == true)
            {
                active = "YES";
                activemain = true;
            }
            else
            {
                active = "NO";
                activemain = false;
            }
            ////   reportManDataSetTableAdapters.StudentInfoTableAdapter insStudentInfo = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
            ////  insStudentInfo.InsertQuery(textBox1.Text,textBox3.Text,textBox4.Text,textBox2.Text,"");
            fullname = textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            DataTable mydt = new DataTable();
            mydt = this.studentInfoTableAdapter.GetDataByStudentExistence(fullname);
            if (mydt.Rows.Count != 0)
            {
                MessageBox.Show("Student with this names already exists in the database, you might consider changing the other names field");
                textBox4.Focus();
                return;

            }

            dob = (DateTime)dateTimePicker1.Value;
            doe = (DateTime)dateTimePicker2.Value;
           // insstudent.InsertQuery(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, fullname, comboBox1.Text, comboBox2.Text, textBox5.Text, textBox9.Text, textBox6.Text, textBox7.Text, textBox8.Text, comboBox5.Text, comboBox3.Text, comboBox4.Text, comboBox6.Text, "YES", dob, filepath);
            insstudent.InsertQuery(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, fullname, comboBox1.Text, comboBox2.Text, textBox5.Text, textBox9.Text, textBox6.Text, textBox7.Text, textBox8.Text, comboBox5.Text, comboBox3.Text, comboBox4.Text, comboBox6.Text, active, dob, filepath, comboBox7.Text, textBox12.Text, textBox10.Text, activemain, comboBox8.Text, doe, comboBox9.Text, textBox11.Text);
            // MessageBox.Show("database updated");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox10.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex =-1;
            tabControl1.SelectedTab = tabPage1;
            filepath = "C:\\reportMAN\\StudentPassport\\blank.jpg";
            pictureBox1.Load(filepath);
            textBox1.Focus();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.statesTableAdapter.FillBylg(this.reportManDataSet.States,comboBox3.Text);
            comboBox4.SelectedIndex = -1;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            this.clasTableAdapter.FillBySchool(this.reportManDataSet.Clas, comboBox9.Text);
            comboBox6.SelectedIndex = -1;
        }
    }
}
