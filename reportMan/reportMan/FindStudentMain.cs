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
    public partial class FindStudentMain : Form
    {
        public string admissionNumber;
        public string searchName;
        Boolean activemain;
        string filepath;
        string fullname;
        DateTime dob;
        DateTime doe;
        string active;
       // string oldFullnamess;
        public FindStudentMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
            
        private void button1_Click(object sender, EventArgs e)
        {
           if (opfil.ShowDialog() != DialogResult.OK)
            { return; }
           /// opfil.ShowDialog();
            filepath = opfil.FileName;
            pictureBox1.Load(filepath);
        }

        private void NewStudentMain_Load(object sender, EventArgs e)
        {
            //string oldFirst, oldSurname, oldOther;
            // TODO: This line of code loads data into the 'reportManDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.reportManDataSet.Bill);
            // TODO: This line of code loads data into the 'reportManDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.reportManDataSet.States);
            // TODO: This line of code loads data into the 'reportManDataSet.Clas' table. You can move, or remove it, as needed.
            this.clasTableAdapter.Fill(this.reportManDataSet.Clas);
            // TODO: This line of code loads data into the 'reportManDataSet.StudentInfo' table. You can move, or remove it, as needed.
           
            
            
            
            
            this.studentInfoTableAdapter.Fill(this.reportManDataSet.StudentInfo);
           /* textBox13.Visible = true;
            textBox14.Visible = true;
            if (textBox14.Text == "YES")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            filepath = textBox13.Text;
            pictureBox1.Load(filepath);
            textBox13.Visible = false;
            textBox14.Visible = false;
            this.CenterToScreen();

            this.Top = 1;*/
            this.studentInfoBindingSource.Position = this.studentInfoBindingSource.Find("FulllName", searchName);
            textBox13.Visible = true;
            textBox14.Visible = true;
            filepath = textBox13.Text;
            if (textBox14.Text == "YES")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
           // filepath = textBox13.Text;
            pictureBox1.Load(filepath);
            textBox13.Visible = false;
            textBox14.Visible = false;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox19.Visible = true;
            if (checkBox1.Checked == true)
            {
                textBox14.Text = "YES";
            }
            else
            {
                textBox14.Text = "NO";
            }
            textBox13.Text = filepath;
            string newfullname, surname, firstname, othernames;
            surname = textBox2.Text.Trim();
            firstname = textBox3.Text.Trim();
            othernames = textBox4.Text.Trim();
            newfullname = surname + " " + firstname + " " + othernames;
            textBox19.Text = newfullname.Trim();
            string comment,Gaddress,othername;
            comment = textBox11.Text;
           textBox11.Text = comment.Trim();
           Gaddress = textBox9.Text;
           textBox9.Text = Gaddress.Trim();
           othername = textBox4.Text;
           textBox4.Text = othername.Trim();
           // textBox11.Text = Trim(comment);
            this.studentInfoBindingSource.EndEdit();
            this.studentInfoTableAdapter.Update(this.reportManDataSet.StudentInfo);
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox19.Visible = false;
            string oldfullname = searchName.Trim();
            this.billTableAdapter.UpdateNames(newfullname, oldfullname);
            MessageBox.Show("Changes updated successfully");
        }

       

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // this.statesTableAdapter.FillBylg(this.reportManDataSet.States, comboBox3.Text);
           // comboBox4.SelectedIndex = -1;
        }

        private void comboBox5_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_Leave(object sender, EventArgs e)
        {
            
        }

        private void FindStudentMain_Activated(object sender, EventArgs e)
        {
         
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this record?", "Want to delete?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.studentInfoBindingSource.RemoveCurrent();
                this.studentInfoBindingSource.EndEdit();
                this.studentInfoTableAdapter.Update(this.reportManDataSet.StudentInfo);
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}