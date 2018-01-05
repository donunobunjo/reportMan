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
    public partial class edit4update : Form
    {
        public string myclass;
        public Int32 iden;
        public decimal ca1, ca2, exam;
        public string sess, term, subj;
        public edit4update()
        {
            InitializeComponent();
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

        private void edit4update_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(ca1);
            textBox2.Text = Convert.ToString(ca2);
            textBox3.Text = Convert.ToString(exam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMarks upm = new UpdateMarks();
            upm.Show();
            //upm.comboBox1.Text = clas;
           // upm.myclass = myclass;
            upm.comboBox2.Text = sess;
            upm.comboBox3.Text = term;
            upm.comboBox4.Text = subj;
            upm.iden = iden;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
