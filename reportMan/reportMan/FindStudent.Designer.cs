namespace reportMan
{
    partial class FindStudent
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportManDataSet = new reportMan.reportManDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentInfoTableAdapter = new reportMan.reportManDataSetTableAdapters.StudentInfoTableAdapter();
            this.formNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fulllNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiansNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiansOfficePhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiansHousePhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiansAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardiansAlternateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGrooupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gendreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localGovtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(255, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formNumberDataGridViewTextBoxColumn,
            this.fulllNameDataGridViewTextBoxColumn,
            this.clasDataGridViewTextBoxColumn,
            this.guardiansNameDataGridViewTextBoxColumn,
            this.guardiansOfficePhoneNumDataGridViewTextBoxColumn,
            this.guardiansHousePhoneNumDataGridViewTextBoxColumn,
            this.guardiansAddressDataGridViewTextBoxColumn,
            this.guardiansAlternateNumberDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.bloodGrooupDataGridViewTextBoxColumn,
            this.genotypeDataGridViewTextBoxColumn,
            this.gendreDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.localGovtDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(849, 365);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.reportManDataSet;
            // 
            // reportManDataSet
            // 
            this.reportManDataSet.DataSetName = "reportManDataSet";
            this.reportManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(162, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // formNumberDataGridViewTextBoxColumn
            // 
            this.formNumberDataGridViewTextBoxColumn.DataPropertyName = "FormNumber";
            this.formNumberDataGridViewTextBoxColumn.HeaderText = "Form Num";
            this.formNumberDataGridViewTextBoxColumn.Name = "formNumberDataGridViewTextBoxColumn";
            this.formNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fulllNameDataGridViewTextBoxColumn
            // 
            this.fulllNameDataGridViewTextBoxColumn.DataPropertyName = "FulllName";
            this.fulllNameDataGridViewTextBoxColumn.HeaderText = "Fulll Name";
            this.fulllNameDataGridViewTextBoxColumn.Name = "fulllNameDataGridViewTextBoxColumn";
            this.fulllNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fulllNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // clasDataGridViewTextBoxColumn
            // 
            this.clasDataGridViewTextBoxColumn.DataPropertyName = "Clas";
            this.clasDataGridViewTextBoxColumn.HeaderText = "Class";
            this.clasDataGridViewTextBoxColumn.Name = "clasDataGridViewTextBoxColumn";
            this.clasDataGridViewTextBoxColumn.ReadOnly = true;
            this.clasDataGridViewTextBoxColumn.Width = 50;
            // 
            // guardiansNameDataGridViewTextBoxColumn
            // 
            this.guardiansNameDataGridViewTextBoxColumn.DataPropertyName = "GuardiansName";
            this.guardiansNameDataGridViewTextBoxColumn.HeaderText = "Guardians Name";
            this.guardiansNameDataGridViewTextBoxColumn.Name = "guardiansNameDataGridViewTextBoxColumn";
            this.guardiansNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guardiansOfficePhoneNumDataGridViewTextBoxColumn
            // 
            this.guardiansOfficePhoneNumDataGridViewTextBoxColumn.DataPropertyName = "GuardiansOfficePhoneNum";
            this.guardiansOfficePhoneNumDataGridViewTextBoxColumn.HeaderText = "Guardians Office PhoneNum";
            this.guardiansOfficePhoneNumDataGridViewTextBoxColumn.Name = "guardiansOfficePhoneNumDataGridViewTextBoxColumn";
            this.guardiansOfficePhoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guardiansHousePhoneNumDataGridViewTextBoxColumn
            // 
            this.guardiansHousePhoneNumDataGridViewTextBoxColumn.DataPropertyName = "GuardiansHousePhoneNum";
            this.guardiansHousePhoneNumDataGridViewTextBoxColumn.HeaderText = "Guardians House PhoneNum";
            this.guardiansHousePhoneNumDataGridViewTextBoxColumn.Name = "guardiansHousePhoneNumDataGridViewTextBoxColumn";
            this.guardiansHousePhoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guardiansAddressDataGridViewTextBoxColumn
            // 
            this.guardiansAddressDataGridViewTextBoxColumn.DataPropertyName = "GuardiansAddress";
            this.guardiansAddressDataGridViewTextBoxColumn.HeaderText = "Guardians Address";
            this.guardiansAddressDataGridViewTextBoxColumn.Name = "guardiansAddressDataGridViewTextBoxColumn";
            this.guardiansAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.guardiansAddressDataGridViewTextBoxColumn.Width = 300;
            // 
            // guardiansAlternateNumberDataGridViewTextBoxColumn
            // 
            this.guardiansAlternateNumberDataGridViewTextBoxColumn.DataPropertyName = "guardiansAlternateNumber";
            this.guardiansAlternateNumberDataGridViewTextBoxColumn.HeaderText = "guardiansAlternateNumber";
            this.guardiansAlternateNumberDataGridViewTextBoxColumn.Name = "guardiansAlternateNumberDataGridViewTextBoxColumn";
            this.guardiansAlternateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bloodGrooupDataGridViewTextBoxColumn
            // 
            this.bloodGrooupDataGridViewTextBoxColumn.DataPropertyName = "BloodGrooup";
            this.bloodGrooupDataGridViewTextBoxColumn.HeaderText = "BloodGrooup";
            this.bloodGrooupDataGridViewTextBoxColumn.Name = "bloodGrooupDataGridViewTextBoxColumn";
            this.bloodGrooupDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodGrooupDataGridViewTextBoxColumn.Visible = false;
            // 
            // genotypeDataGridViewTextBoxColumn
            // 
            this.genotypeDataGridViewTextBoxColumn.DataPropertyName = "Genotype";
            this.genotypeDataGridViewTextBoxColumn.HeaderText = "Genotype";
            this.genotypeDataGridViewTextBoxColumn.Name = "genotypeDataGridViewTextBoxColumn";
            this.genotypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.genotypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // gendreDataGridViewTextBoxColumn
            // 
            this.gendreDataGridViewTextBoxColumn.DataPropertyName = "Gendre";
            this.gendreDataGridViewTextBoxColumn.HeaderText = "Gendre";
            this.gendreDataGridViewTextBoxColumn.Name = "gendreDataGridViewTextBoxColumn";
            this.gendreDataGridViewTextBoxColumn.ReadOnly = true;
            this.gendreDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Visible = false;
            // 
            // localGovtDataGridViewTextBoxColumn
            // 
            this.localGovtDataGridViewTextBoxColumn.DataPropertyName = "localGovt";
            this.localGovtDataGridViewTextBoxColumn.HeaderText = "localGovt";
            this.localGovtDataGridViewTextBoxColumn.Name = "localGovtDataGridViewTextBoxColumn";
            this.localGovtDataGridViewTextBoxColumn.ReadOnly = true;
            this.localGovtDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOBDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportDataGridViewTextBoxColumn.Visible = false;
            // 
            // FindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FindStudent";
            this.Text = "Find Student";
            this.Load += new System.EventHandler(this.FindStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private reportManDataSet reportManDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private reportManDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn formNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fulllNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiansNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiansOfficePhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiansHousePhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiansAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardiansAlternateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGrooupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localGovtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
    }
}