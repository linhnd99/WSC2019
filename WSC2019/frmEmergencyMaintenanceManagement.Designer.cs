﻿namespace WSC2019
{
    partial class frmEmergencyMaintenanceManagement
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
            this.dgvEmergencyMaintenance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencyMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmergencyMaintenance
            // 
            this.dgvEmergencyMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmergencyMaintenance.Location = new System.Drawing.Point(12, 70);
            this.dgvEmergencyMaintenance.Name = "dgvEmergencyMaintenance";
            this.dgvEmergencyMaintenance.Size = new System.Drawing.Size(776, 329);
            this.dgvEmergencyMaintenance.TabIndex = 0;
            this.dgvEmergencyMaintenance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmergencyMaintenance_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Assets:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(15, 406);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(314, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send Emergency Maintenance Request";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // frmEmergencyMaintenanceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmergencyMaintenance);
            this.Name = "frmEmergencyMaintenanceManagement";
            this.Text = "Emergency Maintenance Management";
            this.Load += new System.EventHandler(this.FrmEmergencyMaintenanceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencyMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmergencyMaintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
    }
}