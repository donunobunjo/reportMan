﻿using System;
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
    public partial class FindStudent : Form
    {
        string fname, mname, sname;
        public FindStudent()
        {
            InitializeComponent();
        }

        private void FindStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           //this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
            this.CenterToScreen();

            this.Top = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fname = textBox1.Text.Trim();
            mname = textBox1.Text.Trim();
            sname = textBox1.Text.Trim();
            this.studentInfoTableAdapter.FillFindStudents(this.reportManDataSet.StudentInfo, fname, mname, sname);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  DisplayStudentInfo disp = new DisplayStudentInfo();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // disp.fullname = DataGridView1.SelectedRows(0).Cells(0).Value
                disp.fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                disp.filepath = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                disp.guardianame = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                disp.guardianhomephone = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                disp.guardianofficephone = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                disp.studclass = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                disp.active = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                disp.guardianAddress = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                disp.dob = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                disp.ShowDialog();

            }
            else
            {
                MessageBox.Show("Select a row, by clicking the row marker, before you hit display button");
                return;
            }

            */

            if (dataGridView1.SelectedRows.Count > 0)
            {
                FindStudentMain fsm = new FindStudentMain();
                fsm.admissionNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fsm.searchName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                fsm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a row, by clicking the row marker, before you hit display button");
                return;
            }
        }
    }
}
