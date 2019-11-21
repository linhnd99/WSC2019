namespace WSC2019_Session4
{
    partial class frmInventoryReport
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
            this.cbWarehouse = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdOutOfStock = new System.Windows.Forms.RadioButton();
            this.rdReceivedStock = new System.Windows.Forms.RadioButton();
            this.rdCurrentStock = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse";
            // 
            // cbWarehouse
            // 
            this.cbWarehouse.FormattingEnabled = true;
            this.cbWarehouse.Location = new System.Drawing.Point(28, 67);
            this.cbWarehouse.Name = "cbWarehouse";
            this.cbWarehouse.Size = new System.Drawing.Size(188, 21);
            this.cbWarehouse.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdOutOfStock);
            this.groupBox1.Controls.Add(this.rdReceivedStock);
            this.groupBox1.Controls.Add(this.rdCurrentStock);
            this.groupBox1.Location = new System.Drawing.Point(314, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Type";
            // 
            // rdOutOfStock
            // 
            this.rdOutOfStock.AutoSize = true;
            this.rdOutOfStock.Location = new System.Drawing.Point(264, 19);
            this.rdOutOfStock.Name = "rdOutOfStock";
            this.rdOutOfStock.Size = new System.Drawing.Size(85, 17);
            this.rdOutOfStock.TabIndex = 2;
            this.rdOutOfStock.TabStop = true;
            this.rdOutOfStock.Text = "Out of Stock";
            this.rdOutOfStock.UseVisualStyleBackColor = true;
            // 
            // rdReceivedStock
            // 
            this.rdReceivedStock.AutoSize = true;
            this.rdReceivedStock.Location = new System.Drawing.Point(142, 19);
            this.rdReceivedStock.Name = "rdReceivedStock";
            this.rdReceivedStock.Size = new System.Drawing.Size(102, 17);
            this.rdReceivedStock.TabIndex = 1;
            this.rdReceivedStock.TabStop = true;
            this.rdReceivedStock.Text = "Received Stock";
            this.rdReceivedStock.UseVisualStyleBackColor = true;
            // 
            // rdCurrentStock
            // 
            this.rdCurrentStock.AutoSize = true;
            this.rdCurrentStock.Location = new System.Drawing.Point(16, 19);
            this.rdCurrentStock.Name = "rdCurrentStock";
            this.rdCurrentStock.Size = new System.Drawing.Size(90, 17);
            this.rdCurrentStock.TabIndex = 0;
            this.rdCurrentStock.TabStop = true;
            this.rdCurrentStock.Text = "Current Stock";
            this.rdCurrentStock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.CurrentStock,
            this.ReceivedStock,
            this.Action,
            this.PartID});
            this.dgvParts.Location = new System.Drawing.Point(36, 147);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(752, 291);
            this.dgvParts.TabIndex = 4;
            // 
            // PartName
            // 
            this.PartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            // 
            // CurrentStock
            // 
            this.CurrentStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrentStock.HeaderText = "Current Stock";
            this.CurrentStock.Name = "CurrentStock";
            this.CurrentStock.ReadOnly = true;
            // 
            // ReceivedStock
            // 
            this.ReceivedStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceivedStock.HeaderText = "Received Stock";
            this.ReceivedStock.Name = "ReceivedStock";
            this.ReceivedStock.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // PartID
            // 
            this.PartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Visible = false;
            // 
            // frmInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbWarehouse);
            this.Controls.Add(this.label1);
            this.Name = "frmInventoryReport";
            this.Text = "Inventory Report";
            this.Load += new System.EventHandler(this.frmInventoryReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWarehouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdOutOfStock;
        private System.Windows.Forms.RadioButton rdReceivedStock;
        private System.Windows.Forms.RadioButton rdCurrentStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
    }
}