using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace reportMan
{
    public partial class DefaultersList : Form
    {
        public DefaultersList()
        {
            InitializeComponent();
        }

        private void DefaultersList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.defaulters' table. You can move, or remove it, as needed.
//this.defaultersTableAdapter.Fill(this.reportManDataSet.defaulters);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           // int cnt = dtStudents.Rows.Count;
            string studNames;
             string src = ConfigurationManager.ConnectionStrings[1].ConnectionString;
             using (SqlConnection con = new SqlConnection(src))
             {
                 SqlCommand cmd = new SqlCommand("truncate table defaulters", con);
                 con.Open();
                 cmd.ExecuteNonQuery();
             }
             DataTable dtStudents;
             DataTable dtBillAmount, dtAmountPaid;
             decimal TotalAmountPaid, TotalBillAmount, balance;
             reportManDataSetTableAdapters.StudentInfoTableAdapter activeStudents = new reportManDataSetTableAdapters.StudentInfoTableAdapter();
             reportManDataSetTableAdapters.BillBillAmountTableAdapter BBA = new reportManDataSetTableAdapters.BillBillAmountTableAdapter();
             reportManDataSetTableAdapters.BillAmountPaidTableAdapter BAP = new reportManDataSetTableAdapters.BillAmountPaidTableAdapter();
             reportManDataSetTableAdapters.defaultersTableAdapter insDefaulters = new reportManDataSetTableAdapters.defaultersTableAdapter();
            dtStudents = activeStudents.GetDataByActiveClassStudents(comboBox1.Text);
             foreach (DataRow dr in dtStudents.Rows)
             {
                // subj = drt[0].ToString();
                 studNames = dr[4].ToString().Trim();
                 dtBillAmount = BBA.GetDataByTotalBillAmount(studNames);
                 try
                 {
                     TotalBillAmount = Convert.ToDecimal(dtBillAmount.Rows[0]["TotalBill"].ToString());
                 }
                 catch
                 {
                     TotalBillAmount = 0;
                 }
                 dtAmountPaid = BAP.GetDataByTotalAmountPaid(studNames);
                 try
                 {
                     TotalAmountPaid = Convert.ToDecimal(dtAmountPaid.Rows[0]["TotalAmountPaid"].ToString());
                 }
                 catch
                 {
                     TotalAmountPaid = 0;
                 }
                 balance = TotalBillAmount - TotalAmountPaid;
                 insDefaulters.InsertQuery(studNames, comboBox1.Text, TotalBillAmount, TotalAmountPaid, balance);
                // MessageBox.Show(studNames + "   "+TotalBillAmount+ "     "+TotalAmountPaid+ "     "+balance);
                 this.defaultersTableAdapter.FillByClassDefaulters(this.reportManDataSet.defaulters,comboBox1.Text);
                 this.reportViewer1.RefreshReport();
             }
        }
    }
}
