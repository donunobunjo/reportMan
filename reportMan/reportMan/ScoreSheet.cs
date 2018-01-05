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
    public partial class ScoreSheet : Form
    {
       // public string myclass;
        int sno = 0;
        string classsss, subj, sess, ter;
        public ScoreSheet()
        {
            InitializeComponent();
        }

        private void ScoreSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
                        // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            // TODO: This line of code loads data into the 'reportManDataSet.Subject' table. You can move, or remove it, as needed.
            // this.subjectTableAdapter.Fill(this.reportManDataSet.Subject);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
           // this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
           // comboBox1.SelectedIndex = -1;
           ////

            ///deleted to indexchange of commbo1 cos of the class is now on the form


            //////
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
          //  this.WindowState = FormWindowState.Maximized; ;
            this.CenterToScreen();
            this.Top = 5;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            classsss = comboBox1.Text;
            subj = comboBox2.Text;
            sess = comboBox3.Text;
            ter = comboBox4.Text;
            if (classsss == "")
            {
                MessageBox.Show("You need to select a class");
                return;
            }
            if (subj == "")
            {
                MessageBox.Show("You need to select a subject");
                return;
            }
            if (sess == "")
            {
                MessageBox.Show("You need to select a session");
                return;
            }
            if (ter == "")
            {
                MessageBox.Show("You need to select a term");
                return;
            }
            if (comboBox5.Text == "")
            {
                MessageBox.Show("You need to select a student from the student's combo");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to atleast enter a CA");
                textBox1.Focus();
                return;
            }

            //check for duplicates in the database
            reportManDataSetTableAdapters.checkDuplicatesScoreTableAdapter cheking = new reportManDataSetTableAdapters.checkDuplicatesScoreTableAdapter();
            DataTable dttable = new DataTable();
            dttable = cheking.GetData(comboBox5.Text, comboBox1.Text, comboBox3.Text, comboBox4.Text, comboBox2.Text);
            if (dttable.Rows.Count > 0)
            {
                MessageBox.Show("You have already entered the score for this student, you can update the score by using the update marks menu");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                //comboBox5.SelectedIndex = -1;
                return;
            }

          //check for duplicates in the grid
            string fulname, fnnnames;
            for (int j = 0; j <= this.dataGridView1.RowCount - 1; j++)
            {
                fulname = dataGridView1.Rows[j].Cells[1].Value.ToString();
                fnnnames = comboBox5.Text;
                if (fulname == fnnnames)
                {
                    MessageBox.Show("You have already entered this student marks in the grid, you can't enter it again");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox5.SelectedIndex = -1;
                    return;
                }

            }
            decimal ca1, ca2, exam, total;
            if (textBox1.Text == "")
            {
               textBox1.Text = "0";
                //MessageBox.Show("You need to enter a value for the first C.A.");
                //textBox1.Focus();
                //return;
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
               // MessageBox.Show("You need to enter a value for the second C.A.");
                //textBox2.Focus();
                //return;
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
                //MessageBox.Show("You need to enter a value for the EXAM");
                //textBox3.Focus();
                //return;
            }
            ca1 = Convert.ToDecimal(textBox1.Text);
            ca2 = Convert.ToDecimal(textBox2.Text);
            exam = Convert.ToDecimal(textBox3.Text);
            if (ca1 > 20)
            {
                MessageBox.Show("First C.A. can't be greater than 20");
                textBox1.Focus();
                return;
            }
            if (ca2 > 20)
            {
                MessageBox.Show("Second C.A. can't be greater than 20");
                textBox2.Focus();
                return;
            }
            if (exam >60)
            {
                MessageBox.Show("Exam score can't be greater than 60");
                textBox3.Focus();
                return;
            }
            total = ca1 + ca2 + exam;
            sno = sno + 1;
            string str = Convert.ToString(sno);
            int gridcnt = dataGridView1.RowCount;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[gridcnt].Cells[0].Value = str;
            dataGridView1.Rows[gridcnt].Cells[1].Value = comboBox5.Text;
            dataGridView1.Rows[gridcnt].Cells[2].Value = textBox1.Text;
            dataGridView1.Rows[gridcnt].Cells[3].Value = textBox2.Text;
            dataGridView1.Rows[gridcnt].Cells[4].Value = textBox3.Text;
            dataGridView1.Rows[gridcnt].Cells[5].Value = classsss;
            dataGridView1.Rows[gridcnt].Cells[6].Value = subj;
            dataGridView1.Rows[gridcnt].Cells[7].Value = sess;
            dataGridView1.Rows[gridcnt].Cells[8].Value = ter;
            dataGridView1.Rows[gridcnt].Cells[9].Value = Convert.ToString(total);
            comboBox5.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            if (dataGridView1.RowCount > 0)
            {
                //comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!(comboBox5.Text == "") || !(textBox1.Text == "") || !(textBox2.Text == "") || !(textBox3.Text == ""))
            {
                MessageBox.Show("You still have some info left to be added to the grid");
                return;
            }
            string clas, session, termm,subject, names, c1, c2,exa;
             decimal ca1, ca2, exam;
            reportManDataSetTableAdapters.ResultTableAdapter res = new reportManDataSetTableAdapters.ResultTableAdapter();
            for (int j = 0; j <= this.dataGridView1.RowCount  - 1; j++)
            {
                c1 = dataGridView1.Rows[j].Cells[2].Value.ToString();
                c2 = dataGridView1.Rows[j].Cells[3].Value.ToString();
                exa = dataGridView1.Rows[j].Cells[4].Value.ToString();
                names = dataGridView1.Rows[j].Cells[1].Value.ToString();
                ca1 =Convert.ToDecimal(c1);
                ca2= Convert.ToDecimal(c2);
                exam = Convert.ToDecimal(exa);
                clas = dataGridView1.Rows[j].Cells[5].Value.ToString();
                subject= dataGridView1.Rows[j].Cells[6].Value.ToString();
                session = dataGridView1.Rows[j].Cells[7].Value.ToString();
                termm = dataGridView1.Rows[j].Cells[8].Value.ToString();
                res.InsertQuery(names, clas, session, termm, subject, ca1, ca2, exam);
               
            }
            MessageBox.Show("Database Updated Successfully");
            dataGridView1.Rows.Clear();
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
              //string crit, maincrit;
              //crit = comboBox1.Text;
              //maincrit = crit.Substring(0, 2);

              this.studentInfoTableAdapter.FillBy(this.reportManDataSet.StudentInfo, comboBox1.Text);
              comboBox5.SelectedIndex = -1;
          }*/

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sess = comboBox3.Text;
            //comboBox3.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ter = comboBox4.Text;
            //comboBox4.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

      /*  private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string crit, maincrit;
            crit = myclass;
            maincrit = crit.Substring(0, 2);
            reportManDataSetTableAdapters.SubjectTableAdapter sbj = new reportManDataSetTableAdapters.SubjectTableAdapter();

            if (maincrit == "SS")
            {
                sbj.FillBySSS(this.reportManDataSet.Subject);
            }
            if (maincrit == "JS")
            {
                sbj.FillByJSS(this.reportManDataSet.Subject);
            }
            comboBox2.SelectedIndex = -1;
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScoreSheet_Activated(object sender, EventArgs e)
        {
           /* if (myclass == "ADMIN")
            {
                MessageBox.Show("As an administrator you can't enter marks");
                this.Close();
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this record", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You need to select a row, by clicking the row marker, before you hit the delete button");
            }
        }

        private void ScoreSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult reso = MessageBox.Show("You have some unsaved work, would you like to save it?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (reso == DialogResult.Yes)
                {
                    string clas, session, termm, subject, names, c1, c2, exa;
                    decimal ca1, ca2, exam;
                    reportManDataSetTableAdapters.ResultTableAdapter res = new reportManDataSetTableAdapters.ResultTableAdapter();
                    for (int j = 0; j <= this.dataGridView1.RowCount - 1; j++)
                    {
                        c1 = dataGridView1.Rows[j].Cells[2].Value.ToString();
                        c2 = dataGridView1.Rows[j].Cells[3].Value.ToString();
                        exa = dataGridView1.Rows[j].Cells[4].Value.ToString();
                        names = dataGridView1.Rows[j].Cells[1].Value.ToString();
                        ca1 = Convert.ToDecimal(c1);
                        ca2 = Convert.ToDecimal(c2);
                        exam = Convert.ToDecimal(exa);
                        clas = dataGridView1.Rows[j].Cells[5].Value.ToString();
                        subject = dataGridView1.Rows[j].Cells[6].Value.ToString();
                        session = dataGridView1.Rows[j].Cells[7].Value.ToString();
                        termm = dataGridView1.Rows[j].Cells[8].Value.ToString();
                        res.InsertQuery(names, clas, session, termm, subject, ca1, ca2, exam);

                    }
                }
                else if (reso == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ADMIN")
            {
                MessageBox.Show("As an administrator you are not a form teacher, you can't enter marks");
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportManDataSetTableAdapters.SubjectTableAdapter sbj = new reportManDataSetTableAdapters.SubjectTableAdapter();

            string crit, maincrit;
            crit = comboBox1.Text;
            if (crit == "")
            {
            }
            else
            {
                maincrit = crit.Substring(0, 2);
                // this.studentInfoTableAdapter.FillBy(this.reportManDataSet.StudentInfo, myclass);
                this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo, comboBox1.Text);
                if (maincrit == "SS")
                {
                    sbj.FillBySSS(this.reportManDataSet.Subject);
                }
                if (maincrit == "JS")
                {
                    sbj.FillByJSS(this.reportManDataSet.Subject);
                }
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
