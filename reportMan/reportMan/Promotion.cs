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
    public partial class Promotion : Form
    {
        int flag = 0;
        public Promotion()
        {
            InitializeComponent();
        }

        private void Promotion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.Clas1' table. You can move, or remove it, as needed.
            this.clas1TableAdapter.Fill(this.reportManDataSet.Clas1);
            // TODO: This line of code loads data into the 'reportManDataSet.Promotion' table. You can move, or remove it, as needed.
           // this.promotionTableAdapter.Fill(this.reportManDataSet.Promotion);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            this.CenterToScreen();
            this.Top = 5;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.promotionTableAdapter.FillBy(this.reportManDataSet.Promotion,comboBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.Equals checked)
            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == false)
            {
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = true;
                flag = 1;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = false;
                flag = 1;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You need to select the old class");
                    comboBox1.Focus();
                    return;

            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("You need to select the new class");
                comboBox2.Focus();
                return;

            }
            reportManDataSetTableAdapters.PromotionTableAdapter prom = new reportManDataSetTableAdapters.PromotionTableAdapter();

             for (int j = 0; j <= this.dataGridView1.RowCount - 1; j++)
            {
                bool msg = Convert.ToBoolean(dataGridView1.Rows[j].Cells[2].Value);
                if (msg == true)
                {
                    string namess = dataGridView1.Rows[j].Cells[0].Value.ToString();
                    prom.UpdateQuery(comboBox2.Text, namess);
                }
                
            
             }
             MessageBox.Show("Students have been promoted");
             flag = 0;
             this.Close();
        }

        private void Promotion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 1)
            {
                DialogResult reso = MessageBox.Show("You have some unsaved work, would you like to save it?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (reso == DialogResult.Yes)
                {
                    if (comboBox2.Text == "")
                    {
                        MessageBox.Show("You need to select the new class");
                        e.Cancel = true;

                    }
                    reportManDataSetTableAdapters.PromotionTableAdapter prom = new reportManDataSetTableAdapters.PromotionTableAdapter();

                    for (int j = 0; j <= this.dataGridView1.RowCount - 1; j++)
                    {
                        bool msg = Convert.ToBoolean(dataGridView1.Rows[j].Cells[2].Value);
                        if (msg == true)
                        {
                            string namess = dataGridView1.Rows[j].Cells[0].Value.ToString();
                            prom.UpdateQuery(comboBox2.Text, namess);
                        }


                    }
                }
                else if (reso == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
