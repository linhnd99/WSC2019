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
    public partial class frmAccessRequestDetails : Form
    {
        public frmAccessRequestDetails()
        {
            InitializeComponent();
        }

        private void frmAccessRequestDetails_Load(object sender, EventArgs e)
        {
            //fill data to Selected Asset
            Dictionary<string, string> dataReceived = this.Tag as Dictionary<string, string>;
            lblAssetName.Text = dataReceived["AssetName"];
            lblAssetSN.Text = dataReceived["AssetSN"];
            lblDepartment.Text = dataReceived["Department"];


            //Access EM report
            Session2Entities db = new Session2Entities();
            dpkStartDate.Format = DateTimePickerFormat.Custom;
            dpkStartDate.CustomFormat = "dd//MM/yyyy";
            dpkCompleteOn.Format = DateTimePickerFormat.Custom;
            dpkCompleteOn.CustomFormat = "dd//MM/yyyy";
            int emID = int.Parse(dataReceived["EmergencyMaintenanceID"]);
            dpkStartDate.Value = DateTime.Parse((from x in db.EmergencyMaintenances where x.ID == emID
                                                 select x).FirstOrDefault<EmergencyMaintenance>().EMReportDate.ToString());
            string endDate = (from x in db.EmergencyMaintenances
                            where x.ID == emID
                            select x).FirstOrDefault<EmergencyMaintenance>().EMEndDate.ToString();
            if (endDate == "" || endDate == null) dpkCompleteOn.Value = DateTime.Now;
            else dpkCompleteOn.Value = DateTime.Parse(endDate);
            txtNote.Text = (from x in db.EmergencyMaintenances
                            where x.ID == emID
                            select x).FirstOrDefault<EmergencyMaintenance>().EMTechnicianNote.ToString();


            //Replacement Parts
            var datacb = from x in db.Parts select new {
                Name = x.Name,
                ID = x.ID
            };
            cbPartName.DisplayMember = "Name";
            cbPartName.ValueMember = "ID";
            cbPartName.DataSource = datacb.ToList<object>();

            dgvParts.Rows.Clear();
            List<dynamic> listO = (from x in db.ChangedParts
                        from y in db.Parts
                        where x.PartID == y.ID
                        select new
                        {
                            ChangedPartID = x.ID,
                            EmergencyMaintenanceID = x.EmergencyMaintenanceID,
                            PartID = y.ID,
                            Amount = x.Amount,
                            PartName = y.Name
                        }).ToList<dynamic>();
            
            foreach (dynamic o in listO)
            {
                Dictionary<string, string> row = new Dictionary<string, string>();
                row["ChangedPartID"] = o.ChangedPartID;
                row["EmergencyMaintenanceID"] = o.EmergencyMaintenanceID.ToString();
                row["PartID"] = o.PartID;
                row["Amount"] = o.Amount.ToString();
                row["PartName"] = o.PartName;
                row["Action"] = "Remove";
                dgvParts.Rows.Add(row["PartName"],row["Amount"],row["Action"],row["PartID"],row["ChangedPartID"],row["EmergencyMaintenanceID"]);
            }
        }
        private void lbkRemoveClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel action = sender as LinkLabel;
            dgvParts.Rows[Convert.ToInt32(action.Tag)].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParts.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    dgvParts.Rows[dgvParts.CurrentCell.RowIndex].Visible = false;
                }
                catch (Exception) { }
            }
        }
    }
}
