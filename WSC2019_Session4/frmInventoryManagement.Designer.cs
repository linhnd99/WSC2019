namespace WSC2019_Session4
{
    partial class frmInventoryManagement
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
            this.dgvCurrentIventory = new System.Windows.Forms.DataGridView();
            this.purchaseOrderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentIventory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrentIventory
            // 
            this.dgvCurrentIventory.AllowUserToAddRows = false;
            this.dgvCurrentIventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentIventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.TransactionType,
            this.Date,
            this.Amount,
            this.Source,
            this.Destination,
            this.Action});
            this.dgvCurrentIventory.Location = new System.Drawing.Point(12, 27);
            this.dgvCurrentIventory.Name = "dgvCurrentIventory";
            this.dgvCurrentIventory.Size = new System.Drawing.Size(776, 385);
            this.dgvCurrentIventory.TabIndex = 1;
            // 
            // purchaseOrderManagementToolStripMenuItem
            // 
            this.purchaseOrderManagementToolStripMenuItem.Name = "purchaseOrderManagementToolStripMenuItem";
            this.purchaseOrderManagementToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.purchaseOrderManagementToolStripMenuItem.Text = "Purchase Order Management";
            this.purchaseOrderManagementToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderManagementToolStripMenuItem_Click);
            // 
            // warehouseManagementToolStripMenuItem
            // 
            this.warehouseManagementToolStripMenuItem.Name = "warehouseManagementToolStripMenuItem";
            this.warehouseManagementToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.warehouseManagementToolStripMenuItem.Text = "Warehouse Management";
            this.warehouseManagementToolStripMenuItem.Click += new System.EventHandler(this.warehouseManagementToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.inventoryToolStripMenuItem.Text = "Invertory Report";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderManagementToolStripMenuItem,
            this.warehouseManagementToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PartName
            // 
            this.PartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // TransactionType
            // 
            this.TransactionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "Transaction Type";
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Source.DataPropertyName = "Source";
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // frmInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.dgvCurrentIventory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInventoryManagement";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.frmInventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentIventory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCurrentIventory;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
    }
}