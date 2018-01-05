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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           // this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            this.CenterToScreen();
            this.Top = 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         //////////   this.studentInfoTableAdapter.FillBy1(this.reportManDataSet.StudentInfo, textBox1.Text, textBox1.Text, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
