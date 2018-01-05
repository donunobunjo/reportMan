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
    public partial class EditBill : Form
    {
        public EditBill()
        {
            InitializeComponent();
        }

        private void EditBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Bill' table. You can move, or remove it, as needed.
          //  this.billTableAdapter.Fill(this.reportManDataSet.Bill);
            this.CenterToScreen();
            this.Top = 1;
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo, comboBox1.Text);
            comboBox2.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("You need to select a row, by clicking the row marker, before you hit the Remove button");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.billTableAdapter.Update(this.reportManDataSet.Bill);
            MessageBox.Show("Your changes have been updated");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.billTableAdapter.FillByEditBill(this.reportManDataSet.Bill,comboBox1.Text,comboBox2.Text);
        }
    }
}
