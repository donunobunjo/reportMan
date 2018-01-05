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
    public partial class ChangePassword : Form
    {
        int trials;
        int flag= 0;
        public string myclass;
        public string username;
        public string pwd;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.pwdUsers' table. You can move, or remove it, as needed.
            this.pwdUsersTableAdapter.Fill(this.reportManDataSet.pwdUsers);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            //this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
                     this.CenterToScreen();
                     this.Top = 40;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter a your current password");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("You need to enter your new password");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("You need to confirm your new password");
                textBox4.Focus();
                return;
            }
            if (!(textBox2.Text == pwd))
            {
                MessageBox.Show("You new password you entered does not match your current password");
                textBox2.Focus();
                return;
            }
            if (!(textBox3.Text == textBox4.Text))
            {
                MessageBox.Show("You new password does not match the confirmation");
                textBox3.Focus();
                return;
            }
            this.pwdUsersTableAdapter.UpdateQuery(textBox4.Text, username);
            MessageBox.Show("Your password changed successfully, you will need to restart the application to complete");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Focus();
        }
    }
}
