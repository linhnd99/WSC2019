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
    public partial class frmEmergencyMaintenanceRequest : Form
    {
        public frmEmergencyMaintenanceRequest()
        {
            InitializeComponent();
        }

        private void frmEmergencyMaintenanceRequest_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> tt = this.Tag as Dictionary<string, string>;
            //Fill data to group box Selected Asset
            lblAssetSNValue.Text = tt["AssetSN"];
            lblAssetNameValue.Text = tt["AssetName"];
            Session2Entities db = new Session2Entities();
            Asset asset = (from x in db.Assets
                            where x.AssetSN == lblAssetSNValue.Text && x.AssetName == lblAssetNameValue.Text
                            select x).FirstOrDefault<Asset>();
            IEnumerable<EmergencyMaintenance> list_em = from x in db.EmergencyMaintenances
                                      where x.AssetID == asset.ID
                                      select x;
            
            DepartmentLocation departmentLocation = (from x in db.DepartmentLocations
                                             where x.ID == asset.DepartmentLocationID
                                             select x).FirstOrDefault<DepartmentLocation>();
            Department department = (from x in db.Departments
                                     where x.ID == departmentLocation.DepartmentID
                                     select x).FirstOrDefault<Department>();
            lblDepartmentValue.Text = department.Name;

            //Load combobox
            foreach (Priority temp in (from x in db.Priorities select x))
            {
                cbPriority.Items.Add(temp);
            }
            cbPriority.DisplayMember = "Name";
            cbPriority.ValueMember = "ID";
            cbPriority.SelectedIndex=0;
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            Session2Entities db = new Session2Entities();
            EmergencyMaintenance records = new EmergencyMaintenance();            
            
            //check has emergency closed?
            Asset asset = (from x in db.Assets where x.AssetSN == lblAssetSNValue.Text select x).FirstOrDefault<Asset>();
            EmergencyMaintenance em = (from x in db.EmergencyMaintenances where x.AssetID == asset.ID && x.EMEndDate==null select x).FirstOrDefault<EmergencyMaintenance>();
            records.PriorityID = (cbPriority.SelectedItem as Priority).ID;
            records.DescriptionEmergency = txtDescription.Text;
            records.OtherConsiderations = txtOtherConsideration.Text;
            records.EMReportDate = DateTime.Now.Date;
            records.AssetID = asset.ID;
            if (em != null)
            {
                MessageBox.Show("Asset is maintaining!", "Error");
                return;
            }
            else
            {
                db.EmergencyMaintenances.Add(records);
                db.SaveChanges();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
