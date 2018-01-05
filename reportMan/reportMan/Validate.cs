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
    public partial class Validate : Form
    {
        int totalInClass;
        decimal grandTotalScore, classavgg;
        public Validate()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Validate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.ResultReport' table. You can move, or remove it, as needed.
            this.ResultReportTableAdapter.Fill(this.reportManDataSet.ResultReport);
            // TODO: This line of code loads data into the 'reportManDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.reportManDataSet.Subject);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            // TODO: This line of code loads data into the 'reportManDataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.reportManDataSet.Session);
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true; 
            Int32 cardposn = 1, mainpossn = 1;
            int maincardposn = 1, mainmainposn = 1;
            decimal ca1, ca2, exam, tot;
            string names, fullnames, subject;
           // Int64 count, avg;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to pick a class from the class combo");
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to pick an academic year from the academic year combo");
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("You need to pick a term from the term combo");
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("You need to pick a subject from the subject combo");
                return;
            }

            string src = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            using (SqlConnection con = new SqlConnection(src))
            {
                SqlCommand cmd = new SqlCommand("truncate table ResultReport", con);
                con.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("truncated");
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Result WHERE (Clas = @clas) AND (Session = @sess) AND (Term = @term)", con);
                cmd1.Parameters.AddWithValue("@clas", comboBox1.Text);
                cmd1.Parameters.AddWithValue("@sess", comboBox2.Text);
                cmd1.Parameters.AddWithValue("@term", comboBox3.Text);
                using (SqlDataReader rdr = cmd1.ExecuteReader())
                {
                    using (SqlConnection destncon = new SqlConnection(src))
                    {
                        destncon.Open();
                        using (SqlBulkCopy bc = new SqlBulkCopy(destncon))
                        {
                            bc.DestinationTableName = "ResultReport";
                            bc.WriteToServer(rdr);
                           // MessageBox.Show("bulkcopy");
                        }
                    }
                }
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM Result WHERE (Clas = @clas) AND (Session = @sess) AND (Term = @term)", con);
                cmd2.Parameters.AddWithValue("@clas", comboBox1.Text);
                cmd2.Parameters.AddWithValue("@sess", comboBox2.Text);
                cmd2.Parameters.AddWithValue("@term", comboBox3.Text);
                //con.Open();
                using (SqlDataReader rdr = cmd2.ExecuteReader())
                {
                    
                    while (rdr.Read())
                    {
                        
                        ca1 = Convert.ToDecimal(rdr[6]);
                        ca2 = Convert.ToDecimal(rdr[7]);
                        exam = Convert.ToDecimal(rdr[8]);
                        names = Convert.ToString(rdr[1]);
                        subject = Convert.ToString(rdr[5]);
                        tot = exam + ca1 + ca2;
                        string grad ="";
                        if (tot >=0 && tot <40)
                        {
                            grad = "F";
                        }
                        else if(tot >= 40 && tot <45)
                        {
                            grad = "E";
                        }
                        else if (tot >= 45 && tot < 50)
                        {
                            grad = "D";
                        }
                        else if (tot >= 50 && tot < 65)
                        {
                            grad = "C";
                        }
                        else if (tot >= 65 && tot < 75)
                        {
                            grad = "B";
                        }
                        else
                        {
                            grad = "A";
                        }
                        reportManDataSetTableAdapters.updatetotalTableAdapter total = new reportManDataSetTableAdapters.updatetotalTableAdapter();
                        total.UpdateQuery(tot, grad, comboBox3.Text, comboBox2.Text, comboBox1.Text, names,subject);

                    }
                   // MessageBox.Show("updating total");
                }
                reportManDataSetTableAdapters.distinctsubjTableAdapter distnct = new reportManDataSetTableAdapters.distinctsubjTableAdapter();
                DataTable distcsubj = new DataTable();
                distcsubj = distnct.GetData();
                string subj, checksubj = "anything";
                int count;
                decimal avg, avgsum;
                foreach(DataRow drt in distcsubj.Rows)
                    {
                       // subj = Convert.ToString(distnt[0]);
                        
                        subj = drt[0].ToString();
                        if (!checksubj.Equals(subj))
                        {
                            cardposn = 1;
                            mainpossn = 1;
                        }

                        DataTable mytable = new DataTable();
                        mytable = this.resultReport1TableAdapter.GetData(subj);
                        count = mytable.Rows.Count;
                        reportManDataSetTableAdapters.subjAverageTableAdapter subavg = new reportManDataSetTableAdapters.subjAverageTableAdapter();
                        avgsum = (decimal)subavg.ScalarQuery(subj);
                        avg = avgsum / count;
                        decimal score0 = 0;
                        int cnte = 1;
                        foreach(DataRow dr in mytable.Rows)
                        {
                            
                            decimal score1;
                           fullnames =dr[0].ToString();
                           score1 = (decimal)dr[1];
                           if (score1 == score0)
                           {
                               mainpossn = mainpossn - cnte;
                               cnte = cnte + 1;
                           }
                           else
                           {
                               mainpossn = cardposn;
                               cnte = 1;
                           }
                           score0 = score1;
                            reportManDataSetTableAdapters.UpdateSubjpostnTableAdapter mainposn = new reportManDataSetTableAdapters.UpdateSubjpostnTableAdapter();
                            reportManDataSetTableAdapters.updateavgTableAdapter average = new reportManDataSetTableAdapters.updateavgTableAdapter(); 
                           //
                            reportManDataSetTableAdapters.PositionsTableAdapter p1 = new reportManDataSetTableAdapters.PositionsTableAdapter();
                            string realposn1 = Convert.ToString(mainpossn);
                            DataTable jdata1 = new DataTable();
                            jdata1 = p1.GetDataBy(realposn1);
                            string myposn1 = jdata1.Rows[0][1].ToString();
                            //
                            mainposn.UpdateQuery(myposn1,fullnames,subj);
                            average.UpdateQuery(avg, fullnames,subj);
                            cardposn = cardposn + 1;
                            mainpossn = cardposn;
                            //if (mytable.Rows.Count-1)
                            checksubj = subj;
                        }
                       // MessageBox.Show("i told ya");  
                    }
               // }
                SqlCommand distnctstud = new SqlCommand("SELECT DISTINCT FullName FROM ResultReport",con);
                using(SqlDataReader distnctstudent = distnctstud.ExecuteReader())
                {
                    while (distnctstudent.Read())
                    {
                        string flnames = Convert.ToString(distnctstudent[0]);
                        reportManDataSetTableAdapters.grandtotalTableAdapter gtotal = new reportManDataSetTableAdapters.grandtotalTableAdapter();
                        decimal grtotal = (decimal)gtotal.ScalarQuery(flnames);
                        reportManDataSetTableAdapters.updategrandtotalTableAdapter updgrand = new reportManDataSetTableAdapters.updategrandtotalTableAdapter();
                        updgrand.UpdateQuery(grtotal, flnames);
                    }
                   // MessageBox.Show("grandtotal updated");
                }

            }
            //
            reportManDataSetTableAdapters.ordergrandtotalTableAdapter ord = new reportManDataSetTableAdapters.ordergrandtotalTableAdapter();
            DataTable dtr = new DataTable();
            dtr = ord.GetData();
            decimal scr0 = 0;
            //int maincardposn = 1, mainmainposn = 1
            int counter = 1;
            foreach (DataRow datarw in dtr.Rows)
            {
                string flnamesss;
                decimal scr1;
                flnamesss = datarw[0].ToString();
                scr1 = (decimal)datarw[1];
                if (scr1 == scr0)
                {
                    mainmainposn = mainmainposn - counter;
                    counter = counter + 1;
                }
                else
                {
                    mainmainposn = maincardposn;
                    counter = 1;
                }
                scr0 = scr1;
                reportManDataSetTableAdapters.PositionsTableAdapter p = new reportManDataSetTableAdapters.PositionsTableAdapter();
                string realposn = Convert.ToString(mainmainposn);
                DataTable jdata = new DataTable();
                jdata = p.GetDataBy(realposn);
                string myposn = jdata.Rows[0][1].ToString();
               // ord.UpdateQuery(myposn, flnamesss);
                ord.UpdateQuery(myposn, totalInClass, classavgg, flnamesss);
                maincardposn = maincardposn + 1;
                mainmainposn = maincardposn;
                //this.validateSubjectsTableAdapter.Fill(this.reportManDataSet.validateSubjects, comboBox4.Text);
                this.validateSubjectsTableAdapter.FillBy(this.reportManDataSet.validateSubjects, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
                this.Height = 691;
                this.Width = 809;
                reportViewer1.Visible = true;
                reportViewer1.RefreshReport();
            }
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
        }

        }

