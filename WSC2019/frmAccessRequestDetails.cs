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
            dpkStartDate.Format = DateTimePickerFormat.Custom;
            dpkStartDate.CustomFormat = "dd//MM/yyyy";
            dpkCompleteOn.Format = DateTimePickerFormat.Custom;
            dpkCompleteOn.CustomFormat = "dd//MM/yyyy";

            //Replacement Parts
            Session2Entities db = new Session2Entities();
            var datacb = from x in db.Parts select new {
                ID = x.ID,
                Name = x.Name
            };
            cbPartName.DataSource = datacb;
            cbPartName.DisplayMember = "Name";
            cbPartName.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
