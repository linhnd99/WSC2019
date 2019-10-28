﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2019.Model;

namespace WSC2019
{
    public partial class frmEmergencyMaintenanceManagement : Form
    {
        public string username;
        public frmEmergencyMaintenanceManagement()
        {
            InitializeComponent();
        }

        private void FrmEmergencyMaintenanceManagement_Load(object sender, EventArgs e)
        {
            LoadDataTable();
        }

        private void LoadDataTable()
        {
            Session2Entities db = new Session2Entities();
            dgvEmergencyMaintenance.DataSource = from x in db.SP_GetdgvEmergency(this.username) select x;
        }

        private void DgvEmergencyMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            frmEmergencyMaintenanceRequest frm2 = new frmEmergencyMaintenanceRequest();
            //List<object> dataSend = new List<object>();
            //dataSend.Add(dgvEmergencyMaintenance.SelectedRows[0].ToString());
            //dataSend.Add(dgvEmergencyMaintenance.SelectedRows[1].ToString());
            //int currentRow = dgvEmergencyMaintenance.CurrentRow.Index;
            Dictionary<string, string> dataSend = new Dictionary<string, string>();
            dataSend["AssetSN"] = dgvEmergencyMaintenance.CurrentRow.Cells[0].Value.ToString();
            dataSend["AssetName"] = dgvEmergencyMaintenance.CurrentRow.Cells[1].Value.ToString();
            frm2.Tag = dataSend;
            frm2.ShowDialog();
        }
    }
}
