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
    public partial class AssignTeacherToClass : Form
    {
        public AssignTeacherToClass()
        {
            InitializeComponent();
        }

        private void AssignTeacherToClass_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            this.CenterToScreen();
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to pick a class from the class combo");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the new password");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to confirm the new password");
                textBox2.Focus();
                return;
            }
            if (!(textBox1.Text == textBox2.Text))
            {
                MessageBox.Show("Your password and the confirmation don't match");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                return;
            }
            reportManDataSetTableAdapters.ClasTableAdapter frt = new reportManDataSetTableAdapters.ClasTableAdapter();
            frt.UpdateQuery(textBox2.Text, comboBox1.Text);
            MessageBox.Show("Form teacher has been attached to the class");
            this.Close();
        }
    }
}
