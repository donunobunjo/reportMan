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
    public partial class FindReciept : Form
    {
        public FindReciept()
        {
            InitializeComponent();
        }

        private void FindReciept_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Reciepts' table. You can move, or remove it, as needed.
           // this.recieptsTableAdapter.Fill(this.reportManDataSet.Reciepts);
            this.CenterToScreen();
            this.Top = 1;
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo, comboBox1.Text);
            comboBox2.SelectedIndex = -1;
          
           // comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.recieptsTableAdapter.FillByFindReciept(this.reportManDataSet.Reciepts,comboBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               // FindStudentMain fsm = new FindStudentMain();
               // fsm.admissionNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               // fsm.searchName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
               // fsm.ShowDialog();
                FReciepts fre = new FReciepts();
                fre.namess = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fre.dop = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                fre.amountpaid = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                fre.balance = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                fre.tellerNumber = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                fre.classs = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                fre.session = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                fre.term = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                fre.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a row, by clicking the row marker, before you hit SHOW RECIEPT button");
                return;
            }
        }
    }
}
