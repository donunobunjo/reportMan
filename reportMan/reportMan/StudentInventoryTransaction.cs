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
    public partial class StudentInventoryTransaction : Form
    {
        public StudentInventoryTransaction()
        {
            InitializeComponent();
        }

        private void StudentInventoryTransaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            comboBox1.SelectedIndex = -1;

        }
    }
}
