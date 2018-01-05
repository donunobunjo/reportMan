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
    public partial class UpdateMarks : Form
        
    {
       // public string myclass;
        public Int32 iden;
        int flag = 0;
        public UpdateMarks()
        {
            InitializeComponent();
        }

        private void UpdateMarks_Load(object sender, EventArgs e)
        {
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            // TODO: This line of code loads data into the 'reportManDataSet.Result' table. You can move, or remove it, as needed.
           // this.resultTableAdapter.Fill(this.reportManDataSet.Result);
            // TODO: This line of code loads data into the 'reportManDataSet.Subject' table. You can move, or remove it, as needed.
           // this.subjectTableAdapter.Fill(this.reportManDataSet.Subject);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
           // this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
           
           // comboBox4.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resultTableAdapter.FillBy(this.reportManDataSet.Result,comboBox1.Text,comboBox2.Text,comboBox3.Text,comboBox4.Text);
        }

      /*  private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 iden;
            decimal ca1, ca2, exam;
            string sess, term, subj;
            iden = dataGridView1.CurrentRow.Index;
            ca1 =(decimal)dataGridView1.CurrentRow.Cells[1].Value;
            ca2 = (decimal)dataGridView1.CurrentRow.Cells[2].Value;
            exam = (decimal)dataGridView1.CurrentRow.Cells[3].Value;
            sess = comboBox2.Text;
            term = comboBox3.Text;
            subj = comboBox4.Text;
            edit4update ed = new edit4update();
            ed.iden = iden;
            ed.ca1 = ca1;
            ed.ca2 = ca2;
            ed.exam = exam;
            ed.myclass = myclass;
            ed.sess = sess;
            ed.term = term;
            ed.subj = subj;
            ed.Show();
           // this.Close();

        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
            if (e.ColumnIndex == 1) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    MessageBox.Show("Enter a numeric number");
                    e.Cancel = true;

                }
                else
                {
                    int ca1;
                    ca1 = Convert.ToInt32(e.FormattedValue.ToString());
                    if (ca1 < 0 || ca1 > 20)
                    {
                        MessageBox.Show("Enter a numeric value between 0 and 20");
                        e.Cancel = true;

                    }

                }
            }
            if (e.ColumnIndex == 2) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    MessageBox.Show("Enter a numeric number");
                    e.Cancel = true;

                }
                else
                {
                    int ca2;
                    ca2 = Convert.ToInt32(e.FormattedValue.ToString());
                    if (ca2 < 0 || ca2 > 20)
                    {
                        MessageBox.Show("Enter a numeric value between 0 and 20");
                        //dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        e.Cancel = true;

                    }

                }
            }
            if (e.ColumnIndex == 3) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    MessageBox.Show("Enter a numeric number");
                    e.Cancel = true;

                }
                else
                {
                    int exam;
                    exam = Convert.ToInt32(e.FormattedValue.ToString());
                    if (exam < 0 || exam > 60)
                    {
                        MessageBox.Show("Enter a numeric value between 0 and 60");
                        e.Cancel = true;

                    }

                }
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           flag = 1;          
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resultBindingSource.EndEdit();
            this.resultTableAdapter.Update(this.reportManDataSet.Result);
            MessageBox.Show("Database Updated");

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void UpdateMarks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                DialogResult res = MessageBox.Show("You have some unsaved work, would you like to save your work?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    this.resultBindingSource.EndEdit();
                    this.resultTableAdapter.Update(this.reportManDataSet.Result);
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

      //  private void comboBox4_DropDown(object sender, EventArgs e)
      //  {
      //      if (myclass == "ADMIN")
      //      {
       //         MessageBox.Show("As an administrator you are not a form teacher, you can't enter marks");
      //          this.Close();
        //    }
       // }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string crit, maincrit;
            crit = comboBox1.Text;
            // maincrit = crit.Substring(0, 2);
            if (crit == "")
            {

            }
            else
            {
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
            }
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

       
    }
}
