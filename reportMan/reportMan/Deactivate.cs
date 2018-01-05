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
    public partial class Deactivate : Form
    {
        public Deactivate()
        {
            InitializeComponent();
        }

        private void Deactivate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);

        }
    }
}
