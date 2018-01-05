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
    public partial class NewStudent : Form
    {
        public string myclass;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            this.CenterToScreen();
          
            this.Top = 5;
          
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
           this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter student surname");
                textBox1.Focus();
                return;

            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter student firstname");
                textBox2.Focus();
                return;

            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter student middle name");
                textBox3.Focus();
                
                return;

            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("You need to select a gendre for the student");
                return;
            }
         
            reportManDataSetTableAdapters.check4studentTableAdapter chec = new reportManDataSetTableAdapters.check4studentTableAdapter();
            DataTable checktable = new DataTable();
            checktable = chec.GetData(textBox2.Text, textBox3.Text, textBox1.Text);
            if (checktable.Rows.Count > 0)
            {
                MessageBox.Show("You have already enrolled this student, you can't enroll a student twice");
                return;
            }
            //checking to make sure no duplicate in the datagridview
            string firs, midd, surn,ssname, ffname, mmname;
            firs = textBox2.Text; midd = textBox3.Text; surn = textBox1.Text;
            for (int j = 0; j <= this.dataGridView1.RowCount - 1; j++)
            {
                ssname = dataGridView1.Rows[j].Cells[0].Value.ToString();
                ffname = dataGridView1.Rows[j].Cells[1].Value.ToString();
                mmname = dataGridView1.Rows[j].Cells[2].Value.ToString();
                if ((ssname == surn) && (mmname == midd) && (ffname == firs))
                {
                    MessageBox.Show("You have already added this student to the grid, you can't enroll a student twice");
                    return;
                }

            }


            //
            int gridcnt = dataGridView1.RowCount;
            dataGridView1.Rows.Add();
            //  DataGridView4.Rows(gridcnt - 1).Cells(0).Value = DataGridView1.Rows(0).Cells(1).Value.ToString
            dataGridView1.Rows[gridcnt].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[gridcnt].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[gridcnt].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[gridcnt].Cells[3].Value = myclass;
            if (radioButton1.Checked == true)
            {
                dataGridView1.Rows[gridcnt].Cells[4].Value = "MALE";
               
            }
            else
            {
                dataGridView1.Rows[gridcnt].Cells[4].Value = "FEMALE";
                
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            //comboBox1.SelectedIndex = -1;
            textBox1.Focus();
           // int cnt = dataGridView1.RowCount;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount-1;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "") || !(textBox2.Text == "") || !(textBox3.Text==""))
            {
                MessageBox.Show("You still have some info left to be added to the grid");
                return;
            }
            string fname, mname, sname, fullname, clas, gender;
            reportManDataSetTableAdapters.StudentInfoTableAdapter stdinfo = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
            for (int j = 0; j <= this.dataGridView1.RowCount-1; j++)
            {
                //adcode = DataGridView4.Item(8, j).Value.ToString
                sname = dataGridView1.Rows[j].Cells[0].Value.ToString();
                fname = dataGridView1.Rows[j].Cells[1].Value.ToString();
                mname = dataGridView1.Rows[j].Cells[2].Value.ToString();
                fullname = sname + " " + fname + " " + mname;
                clas = dataGridView1.Rows[j].Cells[3].Value.ToString();
                gender = dataGridView1.Rows[j].Cells[4].Value.ToString();
              ////////  stdinfo.InsertQuery(fname, mname, sname, fullname, gender, clas,"YES");
               
               
            }
            MessageBox.Show("Database Updated Successfully");
            dataGridView1.Rows.Clear();
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

        private void NewStudent_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void NewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count >1)
            {
                DialogResult res = MessageBox.Show("You have some unsaved work, would you like to save your work?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    string fname, mname, sname, fullname, clas, gender;
                    reportManDataSetTableAdapters.StudentInfoTableAdapter stdinfo = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
                    for (int j = 0; j <= (this.dataGridView1.RowCount - 1) - 1; j++)
                    {
                        //adcode = DataGridView4.Item(8, j).Value.ToString
                        sname = dataGridView1.Rows[j].Cells[0].Value.ToString();
                        fname = dataGridView1.Rows[j].Cells[1].Value.ToString();
                        mname = dataGridView1.Rows[j].Cells[2].Value.ToString();
                        fullname = sname + "   " + fname + "   " + mname;
                        clas = dataGridView1.Rows[j].Cells[3].Value.ToString();
                        gender = dataGridView1.Rows[j].Cells[4].Value.ToString();
                      /////////  stdinfo.InsertQuery(fname, mname, sname, fullname, gender, clas, "YES");


                    }
                }
                else if (res == DialogResult.No)
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
    }
}
