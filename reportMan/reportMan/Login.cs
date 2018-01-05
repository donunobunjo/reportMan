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
    public partial class Login : Form
    {
        Int32 trials;
        string myclass;
        string usernme;
        string pwd;
        string roles;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "")
            {
                MessageBox.Show("You need to enter a UserName");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("You need to enter a password");
                textBox2.Focus();
                return;
            }
           
            
                DataTable dt = new DataTable();
               // dt = this.clasTableAdapter.GetDataBy1(textBox1.Text, textBox2.Text);
                dt = this.pwdUsersTableAdapter.GetDataByUserPassword(textBox1.Text, textBox2.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Incorrect Password");
                    // trials = + 1;
                    trials = trials + 1;

                    if (trials == 3)
                    {
                        MessageBox.Show("Shutting down ......");
                        this.Close();
                    }
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    return;
                }
                usernme = dt.Rows[0][1].ToString();
                pwd = dt.Rows[0][2].ToString();
                roles = dt.Rows[0][3].ToString();
               // myclass = textBox1.Text;
                MDI mdi = new MDI();
                mdi.userName = usernme.Trim();
                mdi.pwd = pwd.Trim();
                mdi.roles = roles.Trim();
                mdi.Show();
                this.Hide();
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.pwdUsers' table. You can move, or remove it, as needed.
           //this.pwdUsersTableAdapter.Fill(this.reportManDataSet.pwdUsers);
            // TODO: This line of code loads data into the 'reportManDataSet.TableAD' table. You can move, or remove it, as needed.
            //this.tableADTableAdapter.Fill(this.reportManDataSet.TableAD);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            //this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            this.CenterToScreen();

        }
    }
}
