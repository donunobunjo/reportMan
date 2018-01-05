﻿namespace reportMan
{
    partial class AllInventoryItems
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportManDataSet = new reportMan.reportManDataSet();
            this.inventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryItemTableAdapter = new reportMan.reportManDataSetTableAdapters.InventoryItemTableAdapter();
            this.idenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idenDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryItemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(478, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // reportManDataSet
            // 
            this.reportManDataSet.DataSetName = "reportManDataSet";
            this.reportManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryItemBindingSource
            // 
            this.inventoryItemBindingSource.DataMember = "InventoryItem";
            this.inventoryItemBindingSource.DataSource = this.reportManDataSet;
            // 
            // inventoryItemTableAdapter
            // 
            this.inventoryItemTableAdapter.ClearBeforeFill = true;
            // 
            // idenDataGridViewTextBoxColumn
            // 
            this.idenDataGridViewTextBoxColumn.DataPropertyName = "iden";
            this.idenDataGridViewTextBoxColumn.HeaderText = "iden";
            this.idenDataGridViewTextBoxColumn.Name = "idenDataGridViewTextBoxColumn";
            this.idenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idenDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "CATEGORY";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "ITEM";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDataGridViewTextBoxColumn.Width = 200;
            // 
            // AllInventoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 286);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllInventoryItems";
            this.Text = "All Inventory Items";
            this.Load += new System.EventHandler(this.AllInventoryItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportManDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private reportManDataSet reportManDataSet;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource;
        private reportManDataSetTableAdapters.InventoryItemTableAdapter inventoryItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
    }
}