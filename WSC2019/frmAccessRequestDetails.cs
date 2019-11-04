using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WSC2019.Model;

namespace WSC2019
{
    public partial class frmAccessRequestDetails : Form
    {
        private Dictionary<string, string> dataReceived;
        public frmAccessRequestDetails()
        {
            InitializeComponent();
        }

        private void frmAccessRequestDetails_Load(object sender, EventArgs e)
        {
            //fill data to Selected Asset
            dataReceived = this.Tag as Dictionary<string, string>;
            lblAssetName.Text = dataReceived["AssetName"];
            lblAssetSN.Text = dataReceived["AssetSN"];
            lblDepartment.Text = dataReceived["Department"];
            //dataReceived["EmergencyMaintenanceID"]

            //Access EM report
            Session2Entities db = new Session2Entities();
            dpkStartDate.Format = DateTimePickerFormat.Custom;
            dpkStartDate.CustomFormat = "dd//MM/yyyy";
            dpkCompleteOn.Format = DateTimePickerFormat.Custom;
            dpkCompleteOn.CustomFormat = "dd//MM/yyyy";
            int emID = int.Parse(dataReceived["EmergencyMaintenanceID"]);
            dpkStartDate.Value = DateTime.Parse((from x in db.EmergencyMaintenances
                                                 where x.ID == emID
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
            var datacb = from x in db.Parts
                         select new
                         {
                             Name = x.Name,
                             ID = x.ID
                         };
            cbPartName.DisplayMember = "Name";
            cbPartName.ValueMember = "ID";
            cbPartName.DataSource = datacb.ToList<object>();

            LoadDataTable();
        }

        private void LoadDataTable()
        {
            Session2Entities db = new Session2Entities();
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
                dgvParts.Rows.Add(row["PartName"], row["Amount"], row["Action"], row["PartID"], row["ChangedPartID"], row["EmergencyMaintenanceID"]);
            }
        }
        private void lbkRemoveClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel action = sender as LinkLabel;
            dgvParts.Rows[Convert.ToInt32(action.Tag)].Visible = false;
        }

        private bool isExistReplacementParts(string partid)
        {
            for (int i = 0; i < dgvParts.Rows.Count; i++)
            {
                if (partid.Equals(dgvParts.Rows[i].Cells["PartID"])) return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dynamic tt = cbPartName.SelectedItem;
            if (isExistReplacementParts(tt.ID))
            {
                MessageBox.Show("Part duplicated!", "Error");
                return;
            }
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["PartName"] = tt.Name;
            dic["Amount"] = txtAmount.Text;
            dic["Action"] = "Remove";
            dic["PartID"] = tt.ID;
            dic["ChangedPartID"] = "";
            dic["EmergencyMaintenanceID"] = dataReceived["EmergencyMaintenanceID"];
            dgvParts.Rows.Add(dic["PartName"], dic["Amount"], dic["Action"], dic["PartID"], dic["ChangedPartID"], dic["EmergencyMaintenanceID"]);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Session2Entities db = new Session2Entities();
            //delete changedpart where emid
            int emid = int.Parse(dataReceived["EmergencyMaintenanceID"]);
            IEnumerable<ChangedPart> temp = from x in db.ChangedParts
                                            where x.EmergencyMaintenanceID == emid
                                            select x;
            foreach (ChangedPart cp in temp)
            {
                db.ChangedParts.Remove(cp);
            }
            db.SaveChanges();
            //add changedpart from dgvParts
            for (int i = 0; i < dgvParts.Rows.Count; i++)
            {
                ChangedPart one = new ChangedPart();
                one.ID = "chp" + DateTime.Now.ToString().GetHashCode();
                one.EmergencyMaintenanceID = int.Parse(dataReceived["EmergencyMaintenanceID"]);
                dynamic part = cbPartName.SelectedItem;                
                one.PartID = part.ID;
                one.Amount = Convert.ToDouble(dgvParts.Rows[i].Cells["Amount"].Value);
                db.ChangedParts.Add(one);
            }
            db.SaveChanges();
            //LoadDataTable
            LoadDataTable();
        }

        private void dgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParts.CurrentCell.ColumnIndex == 2)
            {
                try
                {
                    //dgvParts.Rows[dgvParts.CurrentCell.RowIndex].Visible = false;
                    dgvParts.Rows.RemoveAt(dgvParts.CurrentCell.RowIndex);
                }
                catch (Exception) { }
            }
        }
    }
}
