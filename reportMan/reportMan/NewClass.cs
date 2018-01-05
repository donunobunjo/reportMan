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
    public partial class NewClass : Form
    {
        public NewClass()
        {
            InitializeComponent();
        }

        private void NewClass_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportManDataSetTableAdapters.ClasTableAdapter cla = new reportManDataSetTableAdapters.ClasTableAdapter();

            if (comboBox1.Text== "")
            {
                MessageBox.Show("You need to select a school");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter the class");
                textBox1.Focus();
                return;
            }
          
            cla.InsertQuery(textBox1.Text, textBox1.Text,comboBox1.Text);
          
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
