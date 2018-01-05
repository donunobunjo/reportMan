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
    public partial class StudentAcctStatement : Form
    {
        public StudentAcctStatement()
        {
            InitializeComponent();
        }

        private void StudentAcctStatement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Bill' table. You can move, or remove it, as needed.
           // this.BillTableAdapter.Fill(this.reportManDataSet.Bill);
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;
           // this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.studentInfoTableAdapter.FillByActiveClassStudents(this.reportManDataSet.StudentInfo, comboBox1.Text);
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BillTableAdapter.FillByNamess(this.reportManDataSet.Bill, comboBox2.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
