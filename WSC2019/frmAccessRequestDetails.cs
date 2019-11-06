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
            int emID = int.Parse(dataReceived["EmergencyMaintenanceID"]);
            string startDate = (from x in db.EmergencyMaintenances
                                where x.ID == emID
                                select x).FirstOrDefault<EmergencyMaintenance>().EMStartDate.ToString();
            if (startDate == "" || startDate == null) ;
            else mktStartDate.Text = DateTime.Parse(startDate).ToString("dd/MM/yyyy");
            string endDate = (from x in db.EmergencyMaintenances
                              where x.ID == emID
                              select x).FirstOrDefault<EmergencyMaintenance>().EMEndDate.ToString();
            if (endDate == "" || endDate == null) ;
            else mktCompleteOn.Text = DateTime.Parse(endDate).ToString("dd/MM/yyyy");
            txtNote.Text = (from x in db.EmergencyMaintenances
                            where x.ID == emID
                            select x).FirstOrDefault<EmergencyMaintenance>().EMTechnicianNote.ToString();
            if (txtNote.Text == "") mktCompleteOn.Enabled = false;
            else mktCompleteOn.Enabled = true;

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
            int emid = int.Parse(dataReceived["EmergencyMaintenanceID"]);
            List<dynamic> listO = (from x in db.ChangedParts
                                   from y in db.Parts
                                   where x.PartID == y.ID && x.EmergencyMaintenanceID == emid
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
                if (partid.Equals(dgvParts.Rows[i].Cells["PartID"].Value.ToString())) return true;
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
            if (txtAmount.Text == "") dic["Amount"] = "0";
            else dic["Amount"] = txtAmount.Text;
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

            //Check date in MaskedTextBox
            DateTime startDate = new DateTime(), endDate = new DateTime();
            try
            {
                startDate = DateTime.Parse(mktStartDate.Text);
            }
            catch (Exception)
            {
                bool flag = false;
                for (int i = 0; i < mktStartDate.Text.Length; i++)
                    if (mktStartDate.Text[i] <= '9' && mktStartDate.Text[i] >= '0')
                    {
                        flag = true;
                        break;
                    }
                if (flag)
                {
                    MessageBox.Show("Start date invalid", "Error");
                }
                else startDate = new DateTime();
            }
            try
            {
                endDate = DateTime.Parse(mktCompleteOn.Text);
            }
            catch (Exception)
            {
                bool flag = false;
                for (int i = 0; i < mktCompleteOn.Text.Length; i++)
                    if (mktCompleteOn.Text[i] <= '9' && mktCompleteOn.Text[i] >= '0')
                    {
                        flag = true;
                        break;
                    }
                if (flag)
                {
                    MessageBox.Show("End date invalid", "Error");
                }
                else endDate = new DateTime();
            }

            //submit StartDate, CompleteDate, TextNote
            if (startDate.Equals(new DateTime()))
            {
                MessageBox.Show("Start date is empty","Error");
                return;
            }
            if (!startDate.Equals(new DateTime()) && !endDate.Equals(new DateTime())) 
                if (startDate > endDate)
                {
                    MessageBox.Show("Start date must be before Complete On date","Error");
                    return; 
                }
            int emid = int.Parse(dataReceived["EmergencyMaintenanceID"]);
            EmergencyMaintenance one1 = (from x in db.EmergencyMaintenances where x.ID == emid select x).SingleOrDefault<EmergencyMaintenance>();
            one1.EMTechnicianNote = txtNote.Text;
            if (startDate.Equals(new DateTime())==false) one1.EMStartDate = startDate;
            if (endDate.Equals(new DateTime())==false) one1.EMEndDate = endDate;
            db.SaveChanges();

            //submit dgvParts
            //delete changedpart where emid
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
                one.ID = "chp" + (i + 1) * DateTime.Now.ToString().GetHashCode();
                one.EmergencyMaintenanceID = int.Parse(dataReceived["EmergencyMaintenanceID"]);
                one.PartID = dgvParts.Rows[i].Cells["PartID"].Value.ToString();
                one.Amount = Convert.ToDouble(dgvParts.Rows[i].Cells["Amount"].Value);
                db.ChangedParts.Add(one);
            }
            db.SaveChanges();
            //LoadDataTable
            LoadDataTable();
            MessageBox.Show("Submit successful", "Notification");
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

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (txtNote.Text == "") mktCompleteOn.Enabled = false;
            else mktCompleteOn.Enabled = true;
        }
    }
}
