using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2019_Session4.Model;

namespace WSC2019_Session4
{
    public partial class frmInventoryManagement : Form
    {
        private List<Dictionary<string, string>> dataTable;
        private Session4Entities db;
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            //init db
            db = new Session4Entities();

            //init dgvCurrentInventory
            dataTable = new List<Dictionary<string, string>>();
            LoadDataTable();
        }

        private void purchaseOrderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frm2 = new frmPurchaseOrder();
            frm2.ShowDialog();
        }

        private void warehouseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWarehouseManagement frm2 = new frmWarehouseManagement();
            frm2.ShowDialog();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryManagement frm2 = new frmInventoryManagement();
            frm2.ShowDialog();
        }

        private bool Compare(Dictionary<string,string> a, Dictionary<string,string> b)
        {
            DateTime aa = DateTime.Parse(a["Date"]);
            DateTime bb = DateTime.Parse(b["Date"]);
            return aa < bb;
        }

        private void LoadDataTable()
        {
            List<dynamic> listO = (from x in db.SP_GetdgvCurrentInventory() select x).ToList<dynamic>();
            foreach (dynamic o in listO)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>() {
                    { "PartName",o.PartName.ToString() },
                    { "TransactionType",o.TransactionType.ToString() },
                    { "Date", o.Date.ToString("dd/MM/yyyy") },
                    { "Amount", o.Amount.ToString() },
                    { "SourceID", o.SourceID.ToString()},
                    { "DestinationID", o.DestinationID.ToString() },
                };
                int sourceid = int.Parse(temp["SourceID"]);
                int destinationid = int.Parse(temp["DestinationID"]);
                temp["Source"] = (from x in db.Warehouses where sourceid == x.ID select x).FirstOrDefault<Warehouse>().Name;
                temp["Destination"] = (from x in db.Warehouses where destinationid == x.ID select x).FirstOrDefault<Warehouse>().Name;
                dataTable.Add(temp);
            }
            dataTable.Sort(delegate(Dictionary<string, string> a, Dictionary<string, string> b)
            {
                DateTime aa = DateTime.Parse(a["Date"]);
                DateTime bb = DateTime.Parse(b["Date"]);
                if (aa == bb)
                {
                    if (int.Parse(a["Amount"]) == int.Parse(b["Amount"])) return 0;
                    else if (int.Parse(a["Amount"]) > int.Parse(b["Amount"])) return -1;
                    else return 1;
                }
                if (aa < bb) return -1;
                else return 1;
            });
            dgvCurrentIventory.Rows.Clear();
            for (int i=0;i<dataTable.Count;i++)
            {
                Dictionary<string, string> one = dataTable[i];
                dgvCurrentIventory.Rows.Add(one["PartName"], one["TransactionType"], one["Date"], one["Amount"], one["Source"], one["Destination"], "Edit Remove");
                if (one["TransactionType"].Equals("Purchase Order")) dgvCurrentIventory.Rows[i].Cells["Amount"].Style.BackColor = Color.LightGreen;
            }
        }
    }
}
