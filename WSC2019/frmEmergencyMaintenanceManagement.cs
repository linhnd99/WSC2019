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
            foreach (DataGridViewRow row in dgvEmergencyMaintenance.Rows)
            {
                string assetSN = row.Cells["AssetSN"].Value.ToString();
                string assetName = row.Cells["AssetName"].Value.ToString();
                string assetID = (from x in db.Assets where assetSN == x.AssetSN && assetName==x.AssetName select x.ID).SingleOrDefault<string>();
                EmergencyMaintenance em = (from x in db.EmergencyMaintenances where assetID == x.AssetID && x.EMEndDate==null select x).FirstOrDefault<EmergencyMaintenance>();
                if (em!=null)
                {
                    dgvEmergencyMaintenance.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private void DgvEmergencyMaintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //List<object> dataSend = new List<object>();
            //dataSend.Add(dgvEmergencyMaintenance.SelectedRows[0].ToString());
            //dataSend.Add(dgvEmergencyMaintenance.SelectedRows[1].ToString());
            //int currentRow = dgvEmergencyMaintenance.CurrentRow.Index;
            try
            {
                frmEmergencyMaintenanceRequest frm2 = new frmEmergencyMaintenanceRequest();
                Dictionary<string, string> dataSend = new Dictionary<string, string>();
                dataSend["AssetSN"] = dgvEmergencyMaintenance.CurrentRow.Cells["AssetSN"].Value.ToString();
                dataSend["AssetName"] = dgvEmergencyMaintenance.CurrentRow.Cells["AssetName"].Value.ToString();
                frm2.Tag = dataSend;
                frm2.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
