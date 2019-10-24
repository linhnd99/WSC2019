using System;
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

            dgvEmergencyMaintenance.DataSource = db.SP_GetdgvEmergency(this.username);
        }

        private void DgvEmergencyMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
