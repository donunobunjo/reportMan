namespace reportMan
{
    partial class SessionExpenseReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ExpenseReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportManDataSet = new reportMan.reportManDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new reportMan.reportManDataSetTableAdapters.SessionTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExpenseReportTableAdapter = new reportMan.reportManDataSetTableAdapters.ExpenseReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseReportBindingSource
            // 
            this.ExpenseReportBindingSource.DataMember = "ExpenseReport";
            this.ExpenseReportBindingSource.DataSource = this.reportManDataSet;
            // 
            // reportManDataSet
            // 
            this.reportManDataSet.DataSetName = "reportManDataSet";
            this.reportManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SESSION";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sessionBindingSource;
            this.comboBox1.DisplayMember = "Sessionn";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(430, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.reportManDataSet;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ExpenseReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "reportMan.EpenseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(890, 469);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ExpenseReportTableAdapter
            // 
            this.ExpenseReportTableAdapter.ClearBeforeFill = true;
            // 
            // SessionExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 541);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "SessionExpenseReport";
            this.Text = "Session Expense Report";
            this.Load += new System.EventHandler(this.TermlyExpenseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private reportManDataSet reportManDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private reportManDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExpenseReportBindingSource;
        private reportManDataSetTableAdapters.ExpenseReportTableAdapter ExpenseReportTableAdapter;
    }
}