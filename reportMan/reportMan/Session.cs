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
    public partial class Session : Form
    {
        public Session()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Session_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportManDataSetTableAdapters.SessionTableAdapter sess = new reportManDataSetTableAdapters.SessionTableAdapter();
            sess.InsertQuery(textBox1.Text);
            MessageBox.Show("Database Updated Successfully");
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
