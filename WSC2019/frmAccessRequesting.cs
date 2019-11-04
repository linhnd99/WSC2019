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
    public partial class frmAccessRequesting : Form
    {
        public frmAccessRequesting()
        {
            InitializeComponent();
        }

        public static int CompareDynamic(Dictionary<string, string> a, Dictionary<string, string> b)
        {
            Dictionary<string, int> map = new Dictionary<string, int>() {
                ["Very High"] = 1,
                ["High"] = 2,
                ["Normal"] = 3
            };
            int aa = map[a["PriorityName"]];
            int bb = map[b["PriorityName"]];
            if (aa > bb) return 1;
            if (aa == bb)
            {
                return a["RequestDate"].CompareTo(b["RequestDate"]);
            }
            return -1;
        }

        private void frmAccessRequesting_Load(object sender, EventArgs e)
        {
            LoadDataTable();
        }
        private void LoadDataTable()
        {
            Session2Entities db = new Session2Entities();
            //Get data at the first
            dgvRequest.DataSource = db.SP_GetdgvRequest();

            //convert element of DataSource to Dic<string,string>
            List<Dictionary<string, string>> listO = new List<Dictionary<string, string>>();
            for (int i = 0; i < dgvRequest.Rows.Count; i++)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>();
                temp["AssetSN"] = dgvRequest.Rows[i].Cells["AssetSN"].Value.ToString();
                temp["AssetName"] = dgvRequest.Rows[i].Cells["AssetName"].Value.ToString();
                if (dgvRequest.Rows[i].Cells["RequestDate"].Value == null)
                {
                    temp["RequestDate"] = "--";
                }
                else
                {
                    DateTime tdate = DateTime.Parse(dgvRequest.Rows[i].Cells["RequestDate"].Value.ToString());
                    temp["RequestDate"] = tdate.ToString("yyyy/MM/dd");
                }
                temp["EmployeeFullName"] = dgvRequest.Rows[i].Cells["EmployeeFullName"].Value.ToString();
                temp["Department"] = dgvRequest.Rows[i].Cells["Department"].Value.ToString();
                temp["AssetID"] = dgvRequest.Rows[i].Cells["AssetID"].Value.ToString();
                temp["EmergencyMaintenanceID"] = dgvRequest.Rows[i].Cells["EmergencyMaintenanceID"].Value.ToString();
                temp["EmployeeID"] = dgvRequest.Rows[i].Cells["EmployeeID"].Value.ToString();
                temp["DepartmentLocationID"] = dgvRequest.Rows[i].Cells["DepartmentLocationID"].Value.ToString();
                temp["DepartmentID"] = dgvRequest.Rows[i].Cells["DepartmentID"].Value.ToString();
                temp["PriorityName"] = dgvRequest.Rows[i].Cells["PriorityName"].Value.ToString();
                listO.Add(temp);
            }
            //sort Dic<string,string>
            listO.Sort(CompareDynamic);

            //set Dic<string, string which has just sorted to DataSource
            int ii = 0;
            foreach (Dictionary<string, string> temp in listO)
            {
                dgvRequest.Rows[ii].Cells["AssetSN"].Value = temp["AssetSN"];
                dgvRequest.Rows[ii].Cells["AssetName"].Value = temp["AssetName"];
                dgvRequest.Rows[ii].Cells["RequestDate"].Value = temp["RequestDate"];
                dgvRequest.Rows[ii].Cells["EmployeeFullName"].Value = temp["EmployeeFullName"];
                dgvRequest.Rows[ii].Cells["Department"].Value = temp["Department"];
                dgvRequest.Rows[ii].Cells["AssetID"].Value = temp["AssetID"];
                dgvRequest.Rows[ii].Cells["EmergencyMaintenanceID"].Value = int.Parse(temp["EmergencyMaintenanceID"]);
                dgvRequest.Rows[ii].Cells["EmployeeID"].Value = temp["EmployeeID"];
                dgvRequest.Rows[ii].Cells["DepartmentLocationID"].Value = temp["DepartmentLocationID"];
                dgvRequest.Rows[ii].Cells["DepartmentID"].Value = temp["DepartmentID"];
                dgvRequest.Rows[ii].Cells["PriorityName"].Value = temp["PriorityName"];
                ii++;
            }
        }

        private void btnManageRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequest.CurrentRow.Cells["AssetID"].Value==null)
            {
                MessageBox.Show("Records invalid", "Notification");
            }
            else
            {
                frmAccessRequestDetails frm2 = new frmAccessRequestDetails();
                Dictionary<string, string> pack = new Dictionary<string, string>();
                pack["AssetSN"] = dgvRequest.CurrentRow.Cells["AssetSN"].Value.ToString();
                pack["AssetName"] = dgvRequest.CurrentRow.Cells["AssetName"].Value.ToString();
                pack["Department"] = dgvRequest.CurrentRow.Cells["Department"].Value.ToString();
                pack["EmergencyMaintenanceID"] = dgvRequest.CurrentRow.Cells["EmergencyMaintenanceID"].Value.ToString();
                frm2.Tag = pack;
                frm2.ShowDialog(); 
            }
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
