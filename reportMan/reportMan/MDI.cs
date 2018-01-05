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
    public partial class MDI : Form
    {
        public string userName;
        public string pwd;
        public string roles;
      public string myclass;

        public MDI()
        {
            InitializeComponent();
        }

       

        private void MDI_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            if (roles == "admin")
            {
                toolStripMenuItem3.Visible = true;
            }
            /*reportManDataSetTableAdapters.RecieptsTableAdapter rc = new reportManDataSetTableAdapters.RecieptsTableAdapter();
            DataTable rcdt = new DataTable();
            rcdt = rc.GetData();
            if (rcdt.Rows.Count > 150)
            {
                this.toolStrip1.Enabled = false;
                this.menuStrip1.Enabled = false;
                MessageBox.Show("OOOOps something went wrong you need technical support. Please see your vendor");
            }*/

        
           this.CenterToScreen();
           

       }

        private void newClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.MdiParent = this;
            subject.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentMain student = new NewStudentMain();
            student.MdiParent = this;
           // student.myclass = myclass;
            student.Show();
        }

        private void sCORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreSheet SCS = new ScoreSheet();
           SCS.MdiParent = this;
           // SCS.myclass = myclass;
            SCS.Show();
        }

        private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uPDATEMARKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void nEWCLASSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewClass newclass = new NewClass();
            newclass.MdiParent = this;
            newclass.Show();
            
        }

        private void nEWSUBJECTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.MdiParent = this;
            subject.Show();
        }

        private void sESSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nEWSESSIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.MdiParent = this;
            session.Show();
        }

        private void cALCULATORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassTermlyReport ctr = new ClassTermlyReport();
            ctr.MdiParent = this;
            ctr.Show();
        }

        private void nEWMARKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateMarks upm = new UpdateMarks();
            upm.MdiParent = this;
           // upm.myclass = myclass;
            upm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewStudentMain student = new NewStudentMain();
            student.MdiParent = this;
           // student.myclass = myclass;
            student.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ScoreSheet SCS = new ScoreSheet();
            SCS.MdiParent = this;
           // SCS.myclass = myclass;
            SCS.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UpdateMarks upm = new UpdateMarks();
            upm.MdiParent = this;
           // upm.myclass = myclass;
            upm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            QuickFind fnd = new QuickFind();
            fnd.MdiParent = this;
            fnd.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Promotion pro = new Promotion();
            pro.MdiParent = this;
            pro.Show();
        }

        private void mARKSPERSUBJECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validate val = new Validate();
            val.MdiParent = this;
            val.Show();
        }

        private void cHANGEUSERPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.username = userName;
            cp.pwd = pwd;
            cp.MdiParent = this;

            cp.Show();
        }

        private void nEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignTeacherToClass ast = new AssignTeacherToClass();
            ast.MdiParent = this;
            ast.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ClassTermlyReport cls = new ClassTermlyReport();
            cls.MdiParent = this;
            cls.Show();
        }

        private void studentsBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.MdiParent = this;
            bill.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FindStudent fnd = new FindStudent();
            fnd.MdiParent = this;
            fnd.Show();
        }

        private void bILLPAYMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillPayment billpay = new BillPayment();
            billpay.MdiParent = this;
            billpay.Show();
        }

        private void cLASSFEESDEFAULTERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultersList dl = new DefaultersList();
            dl.MdiParent = this;
            dl.Show();
        }

        private void sTUDENTSSTATEMENTOFACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAcctStatement sas = new StudentAcctStatement();
            sas.MdiParent = this;
            sas.Show();
        }

        private void nEWREVENUEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            revenueItem revItem = new revenueItem();
            revItem.MdiParent = this;
            revItem.Show();
        }

        private void rEVENUEENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            revenue rev = new revenue();
            rev.MdiParent = this;
            rev.Show();
        }

        private void nEWEXPENSEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expenseItem expitem = new expenseItem();
            expitem.MdiParent = this;
            expitem.Show();
        }

        private void eXPENSEENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expense exp = new expense();
            exp.MdiParent = this;
            exp.Show();
        }

        private void nEWINVENTORYITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryItem invitem = new inventoryItem();
            invitem.MdiParent = this;
            invitem.Show();
        }

        private void iNVENTORYENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryIn invIN = new inventoryIn();
            invIN.MdiParent = this;
            invIN.Show();
        }

        private void stockOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryOut invOUT = new inventoryOut();
            invOUT.MdiParent = this;
            invOUT.Show();
        }

        private void aLLREVENUEITEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllRevenueItems aRevItems = new AllRevenueItems();
            aRevItems.MdiParent = this;
                aRevItems.Show();
        }

        private void aLLEXPENSEITEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllExpenseItems aExpItems = new AllExpenseItems();
            aExpItems.MdiParent = this;
            aExpItems.Show();
        }

        private void aLLINVENTORYITEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllInventoryItems aInvItems = new AllInventoryItems();
            aInvItems.MdiParent = this;
            aInvItems.Show();
        }

        private void eXPENSESTATEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tERMLYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TermlyExpenseReport termExpReport = new TermlyExpenseReport();
            termExpReport.MdiParent = this;
            termExpReport.Show();
        }

        private void sESSIONToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SessionExpenseReport sessionExpReport = new SessionExpenseReport();
            sessionExpReport.MdiParent = this;
            sessionExpReport.Show();
        }

        private void nEWCLASSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewClass newclass = new NewClass();
            newclass.MdiParent = this;
            newclass.Show();
        }

        private void nEWSUBJECTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void nEWSESSIONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Session session = new Session();
            session.MdiParent = this;
            session.Show();
        }

        private void cONTACTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs about = new ContactUs();
            about.MdiParent = this;
            about.Show();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bYITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemExpenseReport itemexprep = new ItemExpenseReport();
            itemexprep.MdiParent = this;
            itemexprep.Show();
        }

        private void tERMLYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermlyRevenueReport tr = new TermlyRevenueReport();
            tr.MdiParent = this;
            tr.Show();
        }

        private void sESSIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SessionRevenueReport SR = new SessionRevenueReport();
            SR.MdiParent = this;
            SR.Show();
        }

        private void pERIODToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemRevenueReport rev = new ItemRevenueReport();
            rev.MdiParent = this;
            rev.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            FindStudentMain fnde = new FindStudentMain();
            fnde.MdiParent = this;
            fnde.Show();
        }

        private void nEWSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffInfo stinfo = new StaffInfo();
            stinfo.MdiParent = this;
            stinfo.Show();
        }

        private void sTAFFLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffList stlst = new StaffList();
            stlst.MdiParent = this;
            stlst.Show();
        }

        private void toolStripMenuItem18_Click_1(object sender, EventArgs e)
        {

        }

        private void sTAFFITEMSRECIEVEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffItemsRecieved stfrec = new StaffItemsRecieved();
            stfrec.MdiParent = this;
            stfrec.Show();
        }

        private void sTAFFITEMSRETURNEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffItemsReturned stfrtn = new StaffItemsReturned();
            stfrtn.MdiParent = this;
            stfrtn.Show();
        }

        private void sTAFFINVENTORYREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffInventoryReport sir = new StaffInventoryReport();
            sir.MdiParent = this;
            sir.Show();
        }

        private void cONVENTIONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.MdiParent = this;
            subject.Show();
        }

        private void aCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectACE subAce = new SubjectACE();
            subAce.MdiParent = this;
            subAce.Show();
        }

        private void cREATEUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser nuser = new NewUser();
            nuser.MdiParent = this;
            nuser.Show();
        }

        private void dROPUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropUsers dru = new DropUsers();
            dru.MdiParent = this;
            dru.Show();
        }

        private void cHANGEPASSWORDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.username = userName;
            cp.pwd = pwd;
            cp.MdiParent = this;

            cp.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NewScholarshipValue NSV = new NewScholarshipValue();
            NSV.MdiParent = this;
            NSV.Show();
        }

        private void aLLToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllStudents all = new AllStudents();
            all.MdiParent = this;
            all.Show();
        }

        private void aCEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inactiveace INA = new inactiveace();
            INA.MdiParent = this;
            INA.Show();
        }

        private void cONVENTIONALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InactiveConvention incon = new InactiveConvention();
            incon.MdiParent = this;
            incon.Show();
        }

        private void aCEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActiveAce ace = new ActiveAce();
            ace.MdiParent = this;
            ace.Show();
        }

        private void cONVENTIONALToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ActiveConventional accon = new ActiveConventional();
            accon.MdiParent = this;
            accon.Show();
        }

        private void iTEMHISTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemHistoryReport itr = new ItemHistoryReport();
            itr.MdiParent = this;
            itr.Show();
        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentsReport pr = new PaymentsReport();
            pr.MdiParent = this;
            pr.Show();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            StudentInfoList stlist = new StudentInfoList();
            stlist.MdiParent = this;
            stlist.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBill eb = new EditBill();
            eb.MdiParent = this;
            eb.Show();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBillPayment ebp = new EditBillPayment();
            ebp.MdiParent = this;
            ebp.Show();
        }

        private void fINDRECIEPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindReciept fr = new FindReciept();
            fr.MdiParent = this;
            fr.Show();
        }
     }

      
    }

