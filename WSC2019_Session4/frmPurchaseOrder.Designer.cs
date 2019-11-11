namespace WSC2019_Session4
{
    partial class frmPurchaseOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.dpkDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.cbPartname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warehouse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(28, 44);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(190, 21);
            this.cbSuppliers.TabIndex = 3;
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(416, 44);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(190, 21);
            this.cbWarehouse.TabIndex = 4;
            // 
            // dpkDate
            // 
            this.dpkDate.CustomFormat = "dd/MM/yyyy";
            this.dpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkDate.Location = new System.Drawing.Point(78, 81);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Size = new System.Drawing.Size(140, 20);
            this.dpkDate.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPurchaseOrder);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBatchNumber);
            this.groupBox1.Controls.Add(this.cbPartname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts List";
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.AllowUserToAddRows = false;
            this.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.BatchNumber,
            this.Amount,
            this.Action,
            this.ID});
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(6, 71);
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(764, 194);
            this.dgvPurchaseOrder.TabIndex = 7;
            this.dgvPurchaseOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellContentClick);
            // 
            // PartName
            // 
            this.PartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // BatchNumber
            // 
            this.BatchNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNumber.DataPropertyName = "BatchNumber";
            this.BatchNumber.HeaderText = "Batch Number";
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(654, 32);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(484, 35);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Amount";
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.Location = new System.Drawing.Point(322, 35);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBatchNumber.TabIndex = 3;
            // 
            // cbPartname
            // 
            this.cbPartname.FormattingEnabled = true;
            this.cbPartname.Location = new System.Drawing.Point(85, 35);
            this.cbPartname.Name = "cbPartname";
            this.cbPartname.Size = new System.Drawing.Size(121, 21);
            this.cbPartname.TabIndex = 2;
            this.cbPartname.SelectedIndexChanged += new System.EventHandler(this.cbPartname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Batch number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Part name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(416, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dpkDate);
            this.Controls.Add(this.cbWarehouse);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.DateTimePicker dpkDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.ComboBox cbPartname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPurchaseOrder;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}