namespace WSC2019
{
    partial class frmAccessRequestDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAssetSN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangedPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyMaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbPartName = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mktCompleteOn = new System.Windows.Forms.MaskedTextBox();
            this.mktStartDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblAssetName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblAssetSN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Asset";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(650, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 13);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Department";
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(357, 25);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(35, 13);
            this.lblAssetName.TabIndex = 3;
            this.lblAssetName.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "AssetName";
            // 
            // lblAssetSN
            // 
            this.lblAssetSN.AutoSize = true;
            this.lblAssetSN.Location = new System.Drawing.Point(64, 25);
            this.lblAssetSN.Name = "lblAssetSN";
            this.lblAssetSN.Size = new System.Drawing.Size(35, 13);
            this.lblAssetSN.TabIndex = 1;
            this.lblAssetSN.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "AssetSN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mktStartDate);
            this.groupBox2.Controls.Add(this.mktCompleteOn);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset EM Repport";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(52, 85);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(683, 47);
            this.txtNote.TabIndex = 3;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Technician Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complete On";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvParts);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.cbPartName);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(15, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 178);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement parts";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.Amount,
            this.Action,
            this.PartID,
            this.ChangedPartID,
            this.EmergencyMaintenanceID});
            this.dgvParts.Location = new System.Drawing.Point(26, 71);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(729, 89);
            this.dgvParts.TabIndex = 11;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellContentClick);
            // 
            // PartName
            // 
            this.PartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "Partname";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.Action.DefaultCellStyle = dataGridViewCellStyle3;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PartID
            // 
            this.PartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartID.DataPropertyName = "PartID";
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Visible = false;
            // 
            // ChangedPartID
            // 
            this.ChangedPartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChangedPartID.DataPropertyName = "ChangedPartID";
            this.ChangedPartID.HeaderText = "ChangedPartID";
            this.ChangedPartID.Name = "ChangedPartID";
            this.ChangedPartID.ReadOnly = true;
            this.ChangedPartID.Visible = false;
            // 
            // EmergencyMaintenanceID
            // 
            this.EmergencyMaintenanceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmergencyMaintenanceID.DataPropertyName = "EmergencyMaintenanceID";
            this.EmergencyMaintenanceID.HeaderText = "EmergencyMaintenanceID";
            this.EmergencyMaintenanceID.Name = "EmergencyMaintenanceID";
            this.EmergencyMaintenanceID.ReadOnly = true;
            this.EmergencyMaintenanceID.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(657, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbPartName
            // 
            this.cbPartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartName.FormattingEnabled = true;
            this.cbPartName.Location = new System.Drawing.Point(67, 21);
            this.cbPartName.Name = "cbPartName";
            this.cbPartName.Size = new System.Drawing.Size(191, 21);
            this.cbPartName.TabIndex = 9;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(497, 24);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(141, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Part name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(260, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mktCompleteOn
            // 
            this.mktCompleteOn.Location = new System.Drawing.Point(521, 25);
            this.mktCompleteOn.Mask = "00/00/0000";
            this.mktCompleteOn.Name = "mktCompleteOn";
            this.mktCompleteOn.Size = new System.Drawing.Size(100, 20);
            this.mktCompleteOn.TabIndex = 6;
            this.mktCompleteOn.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mktCompleteOn.ValidatingType = typeof(System.DateTime);
            // 
            // mktStartDate
            // 
            this.mktStartDate.Location = new System.Drawing.Point(74, 25);
            this.mktStartDate.Mask = "00/00/0000";
            this.mktStartDate.Name = "mktStartDate";
            this.mktStartDate.Size = new System.Drawing.Size(100, 20);
            this.mktStartDate.TabIndex = 7;
            this.mktStartDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mktStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // frmAccessRequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccessRequestDetails";
            this.Text = "Emergency Maintenace Request Details";
            this.Load += new System.EventHandler(this.frmAccessRequestDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbPartName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAssetSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangedPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyMaintenanceID;
        private System.Windows.Forms.MaskedTextBox mktCompleteOn;
        private System.Windows.Forms.MaskedTextBox mktStartDate;
    }
}