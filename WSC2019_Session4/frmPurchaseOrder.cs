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
        Dictionary<string, string> data ;
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            db = new Session4Entities();
            dataTable = new List<Dictionary<string, string>>();
            data = this.Tag as Dictionary<string, string>;

            cbSuppliers.ValueMember = "ID";
            cbSuppliers.DisplayMember = "Name";
            cbSuppliers.DataSource = (from x in db.Suppliers select x).ToList<Supplier>();
            if (data["Type"] == "Edit") cbSuppliers.SelectedValue = int.Parse(data["SupplierID"]);
            //if (data["Type"] != "Edit") cbSuppliers.SelectedValue = int.Parse(data["SupplierID"]);

            cbWarehouse.ValueMember = "ID";
            cbWarehouse.DisplayMember = "Name";
            cbWarehouse.DataSource = (from x in db.Warehouses select x).ToList<Warehouse>();
            //if (data["Type"] != "Edit") cbWarehouse.SelectedValue = int.Parse(data["WarehouseID"]);
            if (data["Type"] == "Edit") cbSuppliers.SelectedValue = int.Parse(data["WarehouseID"]);

            if (data["Type"] == "Edit") dpkDate.Value = DateTime.Parse(data["Date"]) ;

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
            if (data["Type"]=="Edit")
            {
                dataTable.Clear();
                dgvPurchaseOrder.Rows.Clear();
                List<dynamic> listO = new List<dynamic>();
                listO = db.SP_GetdgvPurchaseOrder(data["SupplierID"],data["WarehouseID"]).ToList<dynamic>();
                dataTable.Clear();
                for (int i = 0; i < listO.Count; i++)
                {
                    dynamic o = listO[i];
                    Dictionary<string, string> one = new Dictionary<string, string>() {
                        {"PartName",o.PartName.ToString() },
                        {"BatchNumber",o.BatchNumber.ToString() },
                        {"Amount",o.Amount.ToString() },
                        {"ID","dgv"+(i+1)*DateTime.Now.GetHashCode() },
                        {"PartID",o.PartID.ToString() },
                        {"OrderItemID",o.OrderItemID.ToString() }
                    };
                    dataTable.Add(one);
                }

                for (int i = 0; i < dataTable.Count; i++)
                {
                    Dictionary<string, string> one = dataTable[i];
                    dgvPurchaseOrder.Rows.Add(one["PartName"], one["BatchNumber"], one["Amount"], "Remove", one["ID"],one["PartID"],one["OrderItemID"]);
                }
            }
            else
            {
                
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
            dgvPurchaseOrder.Rows.Add(one["PartName"], one["BatchNumber"], one["Amount"], "Remove", one["ID"], one["PartID"]);
            OrderItem orderItem = new OrderItem {
                OrderID = Convert.ToInt32(data["OrderID"]),
                Amount = double.Parse(one["Amount"]),
                PartID = int.Parse(one["PartID"]),
                BatchNumber = one["BatchNumber"]
            };
            db.OrderItems.Add(orderItem);
        }

        private void dgvPurchaseOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //click Remove
            int orderitemid = Convert.ToInt32(dgvPurchaseOrder.CurrentRow.Cells["OrderItemID"].Value);
            dgvPurchaseOrder.Rows.RemoveAt(dgvPurchaseOrder.CurrentCell.RowIndex);
            //delete OrderItem
            OrderItem orderItem = (from x in db.OrderItems
                                   where x.ID == orderitemid
                                   select x).SingleOrDefault();
            int orderid = Convert.ToInt32(orderItem.OrderID);
            db.OrderItems.Remove(orderItem);
            List<OrderItem> listOrderItem = (from x in db.Orders
                                             from y in db.OrderItems
                                             where x.ID == y.OrderID
                                             select y).ToList();
            if (listOrderItem == null) 
                db.Orders.Remove((from x in db.Orders where x.ID == orderid select x).SingleOrDefault());
            /*string dgvID = dgvPurchaseOrder.CurrentRow.Cells["ID"].Value.ToString();
            Dictionary<string, string> obj = new Dictionary<string, string>();
            for (int i=0;i<dataTable.Count;i++)
            {
                if (dgvID == dataTable[i]["ID"])
                {
                    int amount = int.Parse(dataTable[i]["Amount"]);
                    if (amount <= 0)
                    {
                        MessageBox.Show("Can not delete this part because amount must be positive number", "Error");
                        return;
                    }
                    else
                    {
                        amount--;
                        dataTable[i]["Amount"] = amount.ToString();
                        dgvPurchaseOrder.CurrentRow.Cells["Amount"].Value = amount.ToString();
                        return;
                    }
                }
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TransactionType trans = (from x in db.TransactionTypes where x.Name == "Purchase Order" select x).FirstOrDefault();
            if (data["Type"] == "New")
            {
                Order order = new Order
                {
                    //ID = null,
                    TransactionTypeID = trans.ID,
                    SupplierID = int.Parse(data["SupplierID"]),
                    SourceWarehouseID = int.Parse(data["WarehouseID"]),
                    DestinationWarehouseID = int.Parse(data["WarehouseID"]),
                    Date = dpkDate.Value
                };
                for (int i=0;i<dgvPurchaseOrder.Rows.Count;i++)
                {
                    OrderItem ordItem = new OrderItem {
                       // ID = null,
                        PartID = Convert.ToInt32(dgvPurchaseOrder.Rows[i].Cells["PartID"].Value),
                        BatchNumber = dgvPurchaseOrder.Rows[i].Cells["BatchNumber"].Value.ToString(),
                        Amount = Convert.ToInt32(dgvPurchaseOrder.Rows[i].Cells["Amount"].Value),
                    };
                    //ordItem.Part = (from x in db.Parts where x.ID == ordItem.PartID select x).SingleOrDefault();
                    order.OrderItems.Add(ordItem);
                }
                db.Orders.Add(order);
                db.SaveChanges();
                return;
            }
            if (data["Type"] == "Edit")
            {
                db.SaveChanges();
                //delete (chỉ trước orderItem, xóa Order sau)
                /*int supplierid = int.Parse(data["SupplierID"]);
                int warehouseid = int.Parse(data["WarehouseID"]);
                List < OrderItem > listOrderItem = (from x in db.OrderItems
                                                    from y in db.Orders
                                                    where x.OrderID == y.ID && y.SupplierID == supplierid && y.SourceWarehouseID == warehouseid
                                                    select x).ToList();
                foreach (OrderItem orderItem in listOrderItem)
                {
                    db.OrderItems.Remove(orderItem);
                }
                List<Order> listOrder = (from x in db.Orders where x.SupplierID == supplierid && x.SourceWarehouseID == warehouseid select x).ToList();
                foreach (Order order in listOrder)
                {
                    db.Orders.Remove(order);
                }

                //insert (thêm Order trước, thêm OrderItem sau)
                
                for (int i=0;i<dgvPurchaseOrder.Rows.Count;i++)
                {

                }*/
            }
        }
    }
}
