namespace reportMan
{
    partial class FindReciept
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportManDataSet = new reportMan.reportManDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasTableAdapter = new reportMan.reportManDataSetTableAdapters.ClasTableAdapter();
            this.studentInfoTableAdapter = new reportMan.reportManDataSetTableAdapters.StudentInfoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recieptsTableAdapter = new reportMan.reportManDataSetTableAdapters.RecieptsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clasBindingSource;
            this.comboBox1.DisplayMember = "Clas";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clasBindingSource
            // 
            this.clasBindingSource.DataMember = "Clas";
            this.clasBindingSource.DataSource = this.reportManDataSet;
            // 
            // reportManDataSet
            // 
            this.reportManDataSet.DataSetName = "reportManDataSet";
            this.reportManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentInfoBindingSource;
            this.comboBox2.DisplayMember = "FulllName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(431, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.reportManDataSet;
            // 
            // clasTableAdapter
            // 
            this.clasTableAdapter.ClearBeforeFill = true;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namessDataGridViewTextBoxColumn,
            this.dOPDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.tellerNumDataGridViewTextBoxColumn,
            this.clasDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.admissionNumberDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.invNumberDataGridViewTextBoxColumn,
            this.idenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recieptsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(928, 410);
            this.dataGridView1.TabIndex = 4;
            // 
            // namessDataGridViewTextBoxColumn
            // 
            this.namessDataGridViewTextBoxColumn.DataPropertyName = "Namess";
            this.namessDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.namessDataGridViewTextBoxColumn.Name = "namessDataGridViewTextBoxColumn";
            this.namessDataGridViewTextBoxColumn.ReadOnly = true;
            this.namessDataGridViewTextBoxColumn.Width = 340;
            // 
            // dOPDataGridViewTextBoxColumn
            // 
            this.dOPDataGridViewTextBoxColumn.DataPropertyName = "DOP";
            this.dOPDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dOPDataGridViewTextBoxColumn.Name = "dOPDataGridViewTextBoxColumn";
            this.dOPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "AMOUNT PAID";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "BAL";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 70;
            // 
            // tellerNumDataGridViewTextBoxColumn
            // 
            this.tellerNumDataGridViewTextBoxColumn.DataPropertyName = "TellerNum";
            this.tellerNumDataGridViewTextBoxColumn.HeaderText = "REF NUM";
            this.tellerNumDataGridViewTextBoxColumn.Name = "tellerNumDataGridViewTextBoxColumn";
            this.tellerNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.tellerNumDataGridViewTextBoxColumn.Width = 70;
            // 
            // clasDataGridViewTextBoxColumn
            // 
            this.clasDataGridViewTextBoxColumn.DataPropertyName = "Clas";
            this.clasDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.clasDataGridViewTextBoxColumn.Name = "clasDataGridViewTextBoxColumn";
            this.clasDataGridViewTextBoxColumn.ReadOnly = true;
            this.clasDataGridViewTextBoxColumn.Width = 60;
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "SESSION";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            this.sessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessionDataGridViewTextBoxColumn.Width = 80;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "TERM";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            this.termDataGridViewTextBoxColumn.Width = 60;
            // 
            // admissionNumberDataGridViewTextBoxColumn
            // 
            this.admissionNumberDataGridViewTextBoxColumn.DataPropertyName = "AdmissionNumber";
            this.admissionNumberDataGridViewTextBoxColumn.HeaderText = "AdmissionNumber";
            this.admissionNumberDataGridViewTextBoxColumn.Name = "admissionNumberDataGridViewTextBoxColumn";
            this.admissionNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.admissionNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolDataGridViewTextBoxColumn.Visible = false;
            // 
            // invNumberDataGridViewTextBoxColumn
            // 
            this.invNumberDataGridViewTextBoxColumn.DataPropertyName = "InvNumber";
            this.invNumberDataGridViewTextBoxColumn.HeaderText = "InvNumber";
            this.invNumberDataGridViewTextBoxColumn.Name = "invNumberDataGridViewTextBoxColumn";
            this.invNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.invNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // idenDataGridViewTextBoxColumn
            // 
            this.idenDataGridViewTextBoxColumn.DataPropertyName = "iden";
            this.idenDataGridViewTextBoxColumn.HeaderText = "iden";
            this.idenDataGridViewTextBoxColumn.Name = "idenDataGridViewTextBoxColumn";
            this.idenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idenDataGridViewTextBoxColumn.Visible = false;
            // 
            // recieptsBindingSource
            // 
            this.recieptsBindingSource.DataMember = "Reciepts";
            this.recieptsBindingSource.DataSource = this.reportManDataSet;
            // 
            // recieptsTableAdapter
            // 
            this.recieptsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(947, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "SHOW RECIEPT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindReciept";
            this.Text = "Find Reciept";
            this.Load += new System.EventHandler(this.FindReciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private reportManDataSet reportManDataSet;
        private System.Windows.Forms.BindingSource clasBindingSource;
        private reportManDataSetTableAdapters.ClasTableAdapter clasTableAdapter;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private reportManDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource recieptsBindingSource;
        private reportManDataSetTableAdapters.RecieptsTableAdapter recieptsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idenDataGridViewTextBoxColumn;
    }
}