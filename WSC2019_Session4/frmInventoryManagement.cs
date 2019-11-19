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

            //var order = new Order
            //{
            //    ID = 20,
            //    Date = DateTime.Now,
            //    SupplierID = 1,
            //    TransactionTypeID = 1,
            //    SourceWarehouseID = 1
            //};

            //var orderItem1 = new OrderItem
            //{
            //    ID = 43,
            //    //OrderID = 20,
            //    Amount = 100,
            //    BatchNumber = "123",
            //    PartID = 3
            //};
            //var orderItem2 = new OrderItem
            //{
            //    ID = 453,
            //    //OrderID = 20,
            //    Amount = 100,
            //    BatchNumber = "123",
            //    PartID = 3
            //};

            //order.OrderItems.Add(orderItem1);
            //order.OrderItems.Add(orderItem2);


            //db.Orders.Add(order);
            //db.SaveChanges();

            //var o = db.Orders.FirstOrDefault();

            //init dgvCurrentInventory
            dataTable = new List<Dictionary<string, string>>();
            LoadDataTable();
        }

        private void purchaseOrderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frm2 = new frmPurchaseOrder();
            Dictionary<string, string> data = new Dictionary<string, string>();
            /*data["SupplierID"] = dgvCurrentIventory.CurrentRow.Cells["SupplierID"].Value.ToString();
            data["WarehouseID"] = dgvCurrentIventory.CurrentRow.Cells["SourceID"].Value.ToString();*/
            data["Type"] = "New";
            frm2.Tag = data;
            frm2.ShowDialog();
            LoadDataTable();
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

        private bool Compare(Dictionary<string, string> a, Dictionary<string, string> b)
        {
            DateTime aa = DateTime.Parse(a["Date"]);
            DateTime bb = DateTime.Parse(b["Date"]);
            return aa < bb;
        }

        private void LoadDataTable()
        {
            List<dynamic> listO = (from x in db.SP_GetdgvCurrentInventory() select x).ToList<dynamic>();
            dataTable.Clear();
            dgvCurrentIventory.Rows.Clear();
            foreach (dynamic o in listO)
            {
                Dictionary<string, string> temp = new Dictionary<string, string>() {
                    { "PartName",o.PartName.ToString() },
                    { "TransactionType",o.TransactionType.ToString() },
                    { "Date", o.Date.ToString("dd/MM/yyyy") },
                    { "Amount", o.Amount.ToString() },
                    { "SourceID", o.SourceID.ToString()},
                    { "DestinationID", o.DestinationID.ToString() },
                    { "SupplierID", o.SupplierID.ToString() },
                    { "OrderItemID",o.OrderItemID.ToString() },
                    {"OrderID",o.OrderID.ToString() }
                };
                int sourceid = int.Parse(temp["SourceID"]);
                int destinationid = int.Parse(temp["DestinationID"]);
                temp["Source"] = (from x in db.Warehouses where sourceid == x.ID select x).FirstOrDefault<Warehouse>().Name;
                temp["Destination"] = (from x in db.Warehouses where destinationid == x.ID select x).FirstOrDefault<Warehouse>().Name;
                dataTable.Add(temp);
            }
            dataTable.Sort(delegate (Dictionary<string, string> a, Dictionary<string, string> b)
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
            for (int i = 0; i < dataTable.Count; i++)
            {
                Dictionary<string, string> one = dataTable[i];
                dgvCurrentIventory.Rows.Add(one["PartName"], one["TransactionType"], one["Date"], one["Amount"], one["Source"], one["Destination"], "Edit","Remove", one["SupplierID"], one["SourceID"], one["DestinationID"], one["OrderItemID"], one["OrderID"]);
                if (one["TransactionType"].Equals("Purchase Order")) dgvCurrentIventory.Rows[i].Cells["Amount"].Style.BackColor = Color.LightGreen;
            }
        }

        private void dgvCurrentIventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //click Remove 
            if (dgvCurrentIventory.CurrentCell.ColumnIndex == 7)
            {
                int orderitemid = Convert.ToInt32(dgvCurrentIventory.Rows[dgvCurrentIventory.CurrentCell.RowIndex].Cells["OrderItemID"].Value);
                OrderItem orderitem = (from x in db.OrderItems where orderitemid == x.ID select x).FirstOrDefault();
                db.OrderItems.Remove(orderitem);
                db.SaveChanges();
                return;
            }

            //click Edit
            if (dgvCurrentIventory.CurrentCell.ColumnIndex==6)
            {
                frmPurchaseOrder frm2 = new frmPurchaseOrder();
                Dictionary<string, string> data = new Dictionary<string, string>();
                data["SupplierID"] = dgvCurrentIventory.CurrentRow.Cells["SupplierID"].Value.ToString();
                data["WarehouseID"] = dgvCurrentIventory.CurrentRow.Cells["SourceID"].Value.ToString();
                data["Date"] = dgvCurrentIventory.CurrentRow.Cells["Date"].Value.ToString();
                data["OrderID"] = dgvCurrentIventory.CurrentRow.Cells["OrderID"].Value.ToString();
                data["Type"] = "Edit";
                frm2.Tag = data;
                frm2.ShowDialog();
                LoadDataTable();
            }

        }
    }
}
