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
    public partial class RecieptsFake : Form
    {
        public string tellerNumber;
        public string namess;
        public string classs;
        public string session;
        public string term;
        public DateTime dop;
        public decimal balance;
        public decimal amountpaid;
        public RecieptsFake()
        {
            InitializeComponent();
        }

        private void Reciepts_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("yipeeeee");
            label2.Text = namess;
            label3.Text = dop.ToShortDateString();
            label4.Text = classs;
            label5.Text = session;
            label6.Text = term;
            label7.Text = amountpaid.ToString();
            label8.Text = balance.ToString();
            richTextBox1.Text = "                           " + "YISHENG SCHOOLS " + "              " + "\r\n\r\n";
           // richTextBox1.AppendText("                       " + "------------------"+ "\r\n\r\n");
            richTextBox1.AppendText("                       " + "SCHOOL RECIEPT" + "\r\n\r\n");
           // richTextBox1.AppendText("                               " + "------------------" + "\r\n\r\n");
            richTextBox1.AppendText("                       " +"Student Name" +"\t"+ namess + "\r\n\r\n");
            richTextBox1.AppendText("                       " +"Date Payment" +"\t"+ dop.ToShortDateString() + "\r\n\r\n");
            richTextBox1.AppendText("                       " + "Class" + "\t"+ classs + "\r\n\r\n");
            richTextBox1.AppendText("                       " + "Session" +"\t"+session + "\r\n\r\n");
            richTextBox1.AppendText("                       " + "Term" +"\t"+term + "\r\n\r\n");
            richTextBox1.AppendText("                       " + "Amount Paid" +"\t"+amountpaid+"\r\n\r\n");
            richTextBox1.AppendText("                       " + "Remaining Balance" + "\t" + balance + "\r\n\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                    
                }
                catch 
                {
                    MessageBox.Show("No printer attached");
                    return;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
