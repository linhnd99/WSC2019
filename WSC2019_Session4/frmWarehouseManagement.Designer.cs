namespace WSC2019_Session4
{
    partial class frmWarehouseManagement
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
            this.cbSourceWarehouse = new System.Windows.Forms.ComboBox();
            this.cbDestinationWarehouse = new System.Windows.Forms.ComboBox();
            this.dpkDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtAmunt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.cbPartname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Warehouse";
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
            // cbSourceWarehouse
            // 
            this.cbSourceWarehouse.FormattingEnabled = true;
            this.cbSourceWarehouse.Location = new System.Drawing.Point(28, 44);
            this.cbSourceWarehouse.Name = "cbSourceWarehouse";
            this.cbSourceWarehouse.Size = new System.Drawing.Size(190, 21);
            this.cbSourceWarehouse.TabIndex = 3;
            // 
            // cbDestinationWarehouse
            // 
            this.cbDestinationWarehouse.FormattingEnabled = true;
            this.cbDestinationWarehouse.Location = new System.Drawing.Point(416, 44);
            this.cbDestinationWarehouse.Name = "cbDestinationWarehouse";
            this.cbDestinationWarehouse.Size = new System.Drawing.Size(190, 21);
            this.cbDestinationWarehouse.TabIndex = 4;
            // 
            // dpkDate
            // 
            this.dpkDate.Location = new System.Drawing.Point(78, 81);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Size = new System.Drawing.Size(200, 20);
            this.dpkDate.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvParts);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.txtAmunt);
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
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(6, 71);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(764, 194);
            this.dgvParts.TabIndex = 7;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(654, 32);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            // 
            // txtAmunt
            // 
            this.txtAmunt.Location = new System.Drawing.Point(484, 35);
            this.txtAmunt.Name = "txtAmunt";
            this.txtAmunt.Size = new System.Drawing.Size(100, 20);
            this.txtAmunt.TabIndex = 5;
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
            this.txtBatchNumber.Location = new System.Drawing.Point(322, 34);
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
            // frmWarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dpkDate);
            this.Controls.Add(this.cbDestinationWarehouse);
            this.Controls.Add(this.cbSourceWarehouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmWarehouseManagement";
            this.Text = "Warehouse Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSourceWarehouse;
        private System.Windows.Forms.ComboBox cbDestinationWarehouse;
        private System.Windows.Forms.DateTimePicker dpkDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txtAmunt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.ComboBox cbPartname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}