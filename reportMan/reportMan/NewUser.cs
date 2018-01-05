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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter a username");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter a password");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to confirm the password");
                textBox3.Focus();
                return;
            }
            if (!(textBox3.Text == textBox2.Text))
            {
                MessageBox.Show("password and confirm password mismatch");
                textBox2.Focus();
                return;
            }
            DataTable mhdt;
            mhdt = this.pwdUsersTableAdapter.GetDataByvalidate(textBox1.Text);
            if (!(mhdt.Rows.Count == 0))
            {
                MessageBox.Show("This user already exists in the system, you will need to change it");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            this.pwdUsersTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, "USER");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();

        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.pwdUsers' table. You can move, or remove it, as needed.
            this.pwdUsersTableAdapter.Fill(this.reportManDataSet.pwdUsers);
            this.CenterToScreen();
            this.Top = 40;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
