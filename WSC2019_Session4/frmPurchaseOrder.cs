using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WSC2019_Session4.Model;

namespace WSC2019_Session4
{
    public partial class frmPurchaseOrder : Form
    {
        private Session4Entities db;
        private List<Dictionary<string, string>> dataTable;
        public frmPurchaseOrder()
        {
            InitializeComponent();
            db = new Session4Entities();
            dataTable = new List<Dictionary<string, string>>();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            cbSuppliers.ValueMember = "ID";
            cbSuppliers.DisplayMember = "Name";
            cbSuppliers.DataSource = (from x in db.Suppliers select x).ToList<Supplier>();

            cbWarehouse.ValueMember = "ID";
            cbWarehouse.DisplayMember = "Name";
            cbWarehouse.DataSource = (from x in db.Warehouses select x).ToList<Warehouse>();

            cbPartname.ValueMember = "ID";
            cbPartname.DisplayMember = "Name";
            cbPartname.DataSource = (from x in db.Parts select x).ToList<Part>();

            LoadDataTable();

            Part part = cbPartname.SelectedItem as Part;
            if (part.BatchNumberHasRequired == false)
            {
                txtBatchNumber.Enabled = false;
                txtBatchNumber.Text = "";
            }
            else txtBatchNumber.Enabled = true;
        }

        private void LoadDataTable()
        {
            List<dynamic> listO = new List<dynamic>();
            listO = db.SP_GetdgvPurchaseOrder().ToList<dynamic>();
            dataTable.Clear();
            for (int i = 0; i < listO.Count; i++)
            {
                dynamic o = listO[i];
                Dictionary<string, string> one = new Dictionary<string, string>() {
                    {"PartName",o.PartName.ToString() },
                    {"BatchNumber",o.BatchNumber.ToString() },
                    {"Amount",o.Amount.ToString() },
                    {"ID","dgv"+(i+1)*DateTime.Now.GetHashCode() },
                    {"PartID",o.PartID.ToString() }
                };
                dataTable.Add(one);
            }

            for (int i = 0; i < dataTable.Count; i++)
            {
                Dictionary<string, string> one = dataTable[i];
                dgvPurchaseOrder.Rows.Add(one["PartName"], one["BatchNumber"], one["Amount"], "Remove", one["ID"]);
            }
        }

        private void cbPartname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Part part = cbPartname.SelectedItem as Part;
            if (part.BatchNumberHasRequired == false)
            {
                txtBatchNumber.Enabled = false;
                txtBatchNumber.Text = "";
            }
            else txtBatchNumber.Enabled = true;

        }

        private bool CheckExistRecord()
        {
            Part part = cbPartname.SelectedItem as Part;
            string partid = part.ID.ToString();
            if (part.BatchNumberHasRequired == false)
            {
                foreach (Dictionary<string, string> o in dataTable)
                {
                    if (int.Parse(o["PartID"]) == part.ID) return true;
                }
            }
            else
            {
                foreach (Dictionary<string, string> o in dataTable)
                {
                    var t = (from x in dataTable where x["PartID"] == partid && txtBatchNumber.Text == x["BatchNumber"] select x).FirstOrDefault<object>();
                    //if (int.Parse(o["PartID"]) == part.ID && txtBatchNumber.Text.Equals(t)) return true;
                    if (t != null) return true;
                }
            }
            return false;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            //Check exist record
            if (CheckExistRecord())
            {
                MessageBox.Show("Record dupplicated");
                return;
            }
            Part part = cbPartname.SelectedItem as Part;
            if (part.BatchNumberHasRequired==true && txtBatchNumber.Text=="")
            {
                MessageBox.Show("Batch number is empty", "Error");
                return;
            }
            try 
            {
                if (txtAmount.Text=="")
                {
                    MessageBox.Show("Amount is empty","Error");
                    return;
                }
                int amount = int.Parse(txtAmount.Text);
                if (amount<0)
                {
                    MessageBox.Show("Amount must be positive number", "Error");
                    return ;
                }
                if (amount<part.MinimumAmount)
                {
                    MessageBox.Show("Amount must be larger than Required Amount of this part", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Amount invalid","Error");
                return;
            }

            Dictionary<string, string> one = new Dictionary<string, string>();
            one["PartName"] = part.Name;
            one["BatchNumber"] = txtBatchNumber.Text;
            one["Amount"] = txtAmount.Text;
            one["ID"] = "dgv" + (0 + 1) * DateTime.Now.GetHashCode();
            one["PartID"] = part.ID.ToString() ;
            dataTable.Add(one);
            dgvPurchaseOrder.Rows.Add(one["PartName"], one["BatchNumber"], one["Amount"], "Remove", one["ID"]);
        }

        private void dgvPurchaseOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dgvID = dgvPurchaseOrder.CurrentRow.Cells["ID"].Value.ToString();
            Dictionary<string, string> obj = new Dictionary<string, string>();
            for (int i=0;i<dataTable.Count;i++)
            {
                if (dgvID == dataTable[i]["ID"])
                {
                    int amount = int.Parse(dataTable[i]["Amount"]);
                    if (amount <= 0)
                    {
                        MessageBox.Show("Can not delete this part because amount must be positive number", "Error");
                    }
                }
                else
                {
                    int amount = int.Parse(dataTable[i]["Amount"]);
                    amount--;
                    dataTable[i]["Amount"] = amount.ToString();
                }
            }
        }
    }
}
