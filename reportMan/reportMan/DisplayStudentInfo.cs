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
    public partial class DisplayStudentInfo : Form
    {
        public string filepath;
        public string fullname;
        public string guardianame;
        public string guardianhomephone;
        public string guardianofficephone;
        public string studclass;
        public string active;
        public string guardianAddress;
        public string dob;
        public DisplayStudentInfo()
        {
            InitializeComponent();
        }

        private void DisplayStudentInfo_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(filepath);
            textBox1.Text = fullname;
            textBox2.Text = studclass;
            textBox3.Text = active;
            textBox4.Text = dob;
            textBox5.Text = guardianame;
            textBox6.Text = guardianhomephone;
            textBox7.Text = guardianofficephone;
            textBox8.Text = guardianAddress;
            this.Top = 30;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
