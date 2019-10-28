namespace WSC2019
{
    partial class frmAccessRequesting
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
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.btnManageRequest = new System.Windows.Forms.Button();
            this.AssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmergencyMaintenanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Assets Requesting EM:";
            // 
            // dgvRequest
            // 
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetSN,
            this.AssetName,
            this.RequestDate,
            this.EmployeeFullName,
            this.Department,
            this.AssetID,
            this.EmergencyMaintenanceID,
            this.EmployeeID,
            this.DepartmentLocationID,
            this.DepartmentID,
            this.PriorityName});
            this.dgvRequest.Location = new System.Drawing.Point(13, 64);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.Size = new System.Drawing.Size(709, 331);
            this.dgvRequest.TabIndex = 1;
            this.dgvRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellContentClick);
            // 
            // btnManageRequest
            // 
            this.btnManageRequest.Location = new System.Drawing.Point(16, 415);
            this.btnManageRequest.Name = "btnManageRequest";
            this.btnManageRequest.Size = new System.Drawing.Size(184, 23);
            this.btnManageRequest.TabIndex = 2;
            this.btnManageRequest.Text = "Manage Request";
            this.btnManageRequest.UseVisualStyleBackColor = true;
            this.btnManageRequest.Click += new System.EventHandler(this.btnManageRequest_Click);
            // 
            // AssetSN
            // 
            this.AssetSN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetSN.DataPropertyName = "AssetSN";
            this.AssetSN.HeaderText = "Asset SN";
            this.AssetSN.Name = "AssetSN";
            this.AssetSN.ReadOnly = true;
            // 
            // AssetName
            // 
            this.AssetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetName.DataPropertyName = "AssetName";
            this.AssetName.HeaderText = "Asset Name";
            this.AssetName.Name = "AssetName";
            this.AssetName.ReadOnly = true;
            // 
            // RequestDate
            // 
            this.RequestDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RequestDate.DataPropertyName = "RequestDate";
            this.RequestDate.HeaderText = "Request Date";
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.EmployeeFullName.HeaderText = "Employee Full Name";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // AssetID
            // 
            this.AssetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssetID.DataPropertyName = "AssetID";
            this.AssetID.HeaderText = "AssetID";
            this.AssetID.Name = "AssetID";
            this.AssetID.ReadOnly = true;
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
            // EmployeeID
            // 
            this.EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            // 
            // DepartmentLocationID
            // 
            this.DepartmentLocationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentLocationID.DataPropertyName = "DepartmentLocationID";
            this.DepartmentLocationID.HeaderText = "DepartmentLocationID";
            this.DepartmentLocationID.Name = "DepartmentLocationID";
            this.DepartmentLocationID.ReadOnly = true;
            this.DepartmentLocationID.Visible = false;
            // 
            // DepartmentID
            // 
            this.DepartmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "DepartmentID";
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.ReadOnly = true;
            this.DepartmentID.Visible = false;
            // 
            // PriorityName
            // 
            this.PriorityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriorityName.DataPropertyName = "PriorityName";
            this.PriorityName.HeaderText = "Priority Name";
            this.PriorityName.Name = "PriorityName";
            this.PriorityName.ReadOnly = true;
            // 
            // frmAccessRequesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.btnManageRequest);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.label1);
            this.Name = "frmAccessRequesting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Maintenance Management";
            this.Load += new System.EventHandler(this.frmAccessRequesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageRequest;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmergencyMaintenanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityName;
    }
}