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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            double rvalue;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select a class");
                comboBox1.Focus();
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
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to select a name");
                comboBox4.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter bill amount");
                textBox2.Focus();
                return;
            }
            DataTable mhdata;
            mhdata = this.scholarshipValueTableAdapter.GetDataScholarshipValue(comboBox4.Text);
            string svalue = mhdata.Rows[0][0].ToString().Trim();
          //  Int32 rvalue = Int32.Parse(svalue);

            //scholarship info
            try
            {
                rvalue = System.Convert.ToDouble(svalue);
            }
            catch
            {
                 rvalue = 0;
            }

            //scholarshipinfo
            double ramount = System.Convert.ToDouble(textBox2.Text);
           // Int32 billAmount = ramount - ((rvalue / 100) * ramount);
            float disc = (float)rvalue /(float) 100;
            decimal billAmount = (decimal)(ramount -(disc*ramount));


            int gridcnt = dataGridView1.RowCount;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[gridcnt].Cells[0].Value = comboBox4.Text;
            dataGridView1.Rows[gridcnt].Cells[1].Value = billAmount.ToString();
            dataGridView1.Rows[gridcnt].Cells[2].Value = comboBox1.Text;
            dataGridView1.Rows[gridcnt].Cells[3].Value = comboBox2.Text;
            dataGridView1.Rows[gridcnt].Cells[4].Value = comboBox3.Text;
            comboBox4.SelectedIndex = -1;
            textBox2.Clear();
            if (dataGridView1.RowCount > 0)
            {
                //comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox1.Enabled = false;
            }
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(comboBox4.Text == "") || !(textBox2.Text == ""))
            {
                MessageBox.Show("You still have some info left to be added to the grid");
                return;
            }
            decimal billamount;
            string classs, session, term, namess, billamountgrid;
            reportManDataSetTableAdapters.BillTableAdapter insBill = new reportManDataSetTableAdapters.BillTableAdapter();
            for (int j = 0; j <= this.dataGridView1.RowCount - 1; j++)
            {
                classs = dataGridView1.Rows[j].Cells[2].Value.ToString();
                session = dataGridView1.Rows[j].Cells[3].Value.ToString();
                term = dataGridView1.Rows[j].Cells[4].Value.ToString();
                namess = dataGridView1.Rows[j].Cells[0].Value.ToString();
                billamountgrid = dataGridView1.Rows[j].Cells[1].Value.ToString();
                billamount = Convert.ToDecimal(billamountgrid);
                insBill.InsertQuery("", namess, classs, session, term, DateTime.Today, billamount, 0);
            }
            MessageBox.Show("Database Updated Successfully");
            dataGridView1.Rows.Clear();
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox1.Enabled = true;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo, comboBox1.Text);
            comboBox4.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
