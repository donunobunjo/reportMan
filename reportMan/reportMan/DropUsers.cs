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
    public partial class DropUsers : Form
    {
        public DropUsers()
        {
            InitializeComponent();
        }

        private void DropUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.pwdUsers' table. You can move, or remove it, as needed.
           // this.pwdUsersTableAdapter.Fill(this.reportManDataSet.pwdUsers);
            this.pwdUsersTableAdapter.FillByRoles(this.reportManDataSet.pwdUsers, "USER");
            this.CenterToScreen();
            this.Top = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this user", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    this.pwdUsersTableAdapter.Update(this.reportManDataSet.pwdUsers);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You need to select a row, by clicking the row marker, before you hit the delete button");
            }
        }
    }
}
