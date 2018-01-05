namespace reportMan
{
    partial class ReportSheet
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ResultReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportManDataSet = new reportMan.reportManDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResultReportTableAdapter = new reportMan.reportManDataSetTableAdapters.ResultReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ResultReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultReportBindingSource
            // 
            this.ResultReportBindingSource.DataMember = "ResultReport";
            this.ResultReportBindingSource.DataSource = this.reportManDataSet;
            // 
            // reportManDataSet
            // 
            this.reportManDataSet.DataSetName = "reportManDataSet";
            this.reportManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResultReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "reportMan.TermlyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // ResultReportTableAdapter
            // 
            this.ResultReportTableAdapter.ClearBeforeFill = true;
            // 
            // ReportSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 774);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportSheet";
            this.Text = "TERMLY REPORT SHEET";
            this.Load += new System.EventHandler(this.ReportSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ResultReportBindingSource;
        private reportManDataSet reportManDataSet;
        private reportManDataSetTableAdapters.ResultReportTableAdapter ResultReportTableAdapter;
    }
}