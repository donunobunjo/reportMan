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
    public partial class FReciepts : Form
    {
        public string tellerNumber;
        public string namess;
        public string classs;
        public string session;
        public string term;
        public DateTime dop;
        public decimal balance;
        public decimal amountpaid;
        public FReciepts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Reciepts' table. You can move, or remove it, as needed.
           // this.RecieptsTableAdapter.Fill(this.reportManDataSet.Reciepts);
            this.RecieptsTableAdapter.FillByReciept(this.reportManDataSet.Reciepts, tellerNumber.Trim(), namess.Trim(), classs.Trim(), session.Trim(), term.Trim(), dop, balance, amountpaid);
            this.reportViewer1.RefreshReport();
        }
    }
}
