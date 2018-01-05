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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Top = 40;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cate;
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the subject");
                textBox1.Focus();
                return;
            }
           
            if (radioButton1.Checked == true)

            {
                cate = "ALL";
            }
            else if (radioButton2.Checked == true)
            {
                cate = "SSS";
            }
            else if (radioButton3.Checked == true)
            {
                cate = "JSS";
            }
            else if (radioButton5.Checked == true)
            {
                cate = "PRI";
            }
            else if (radioButton4.Checked == true)
            {
                cate = "NUR";
            }
            else
            {
                cate = "PLY";
            }
            reportManDataSetTableAdapters.SubjectTableAdapter subject = new reportManDataSetTableAdapters.SubjectTableAdapter();
            subject.InsertQuery(textBox1.Text, cate,"COVENTIONAL");
            MessageBox.Show("Database Updated Successfully");
            textBox1.Clear();
            radioButton1.Checked = true;
            textBox1.Focus();
        }
    }
}
