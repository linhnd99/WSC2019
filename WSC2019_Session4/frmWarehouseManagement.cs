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
    public partial class frmWarehouseManagement : Form
    {
        private Session4Entities db = new Session4Entities();
        private Dictionary<string, string> data;
        public frmWarehouseManagement()
        {
            InitializeComponent();
        }

        private void frmWarehouseManagement_Load(object sender, EventArgs e)
        {
            data = this.Tag as Dictionary<string, string>;

            cbSourceWarehouse.ValueMember = "ID";
            cbSourceWarehouse.DisplayMember = "Name";
            cbSourceWarehouse.DataSource = (from x in db.Warehouses select x).ToList();

            cbDestinationWarehouse.ValueMember = "ID";
            cbDestinationWarehouse.DisplayMember = "Name";
            cbDestinationWarehouse.DataSource = (from x in db.Warehouses select x).ToList();

            if (data["Type"]=="New")
            {
                cbSourceWarehouse.SelectedIndex = -1;
                cbDestinationWarehouse.SelectedIndex = -1;
            }
            else
            {

            }
        }

        private void cbSourceWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load cbPartName
            cbPartname.ValueMember = "ID";
            cbPartname.DisplayMember = "Name";
            if (cbDestinationWarehouse.SelectedIndex != -1)
            {
                int destinationid = Convert.ToInt32(cbDestinationWarehouse.SelectedValue);
                int sourceid = Convert.ToInt32(cbSourceWarehouse.SelectedValue);
                cbPartname.DataSource = (from x in db.Orders
                                        join y in db.OrderItems on x.ID equals y.OrderID
                                        join z in db.Parts on y.PartID equals z.ID
                                        where sourceid == x.SourceWarehouseID && destinationid == x.DestinationWarehouseID
                                        select z).ToList();
            }
            else
            {
                int sourceid = Convert.ToInt32(cbSourceWarehouse.SelectedValue);
                cbPartname.DataSource = (from x in db.Orders
                                        join y in db.OrderItems on x.ID equals y.OrderID
                                        join z in db.Parts on y.PartID equals z.ID
                                        where sourceid == x.SourceWarehouseID
                                        select z).ToList();
            }
            cbPartname.SelectedIndex = -1;
        }

        private void cbDestinationWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load cbPartName
            cbPartname.ValueMember = "ID";
            cbPartname.DisplayMember = "Name";
            if (cbSourceWarehouse.SelectedIndex != -1)
            {
                int destinationid = Convert.ToInt32(cbDestinationWarehouse.SelectedValue);
                int sourceid = Convert.ToInt32(cbSourceWarehouse.SelectedValue);
                cbPartname.DataSource = (from x in db.Orders
                                        join y in db.OrderItems on x.ID equals y.OrderID
                                        join z in db.Parts on y.PartID equals z.ID
                                        where sourceid == x.SourceWarehouseID && destinationid == x.DestinationWarehouseID
                                        select z).ToList();
            }
            else
            {
                int destinationid = Convert.ToInt32(cbDestinationWarehouse.SelectedValue);
                cbPartname.DataSource = (from x in db.Orders
                                        join y in db.OrderItems on x.ID equals y.OrderID
                                        join z in db.Parts on y.PartID equals z.ID
                                        where destinationid == x.DestinationWarehouseID
                                        select z).ToList();
            }
            cbPartname.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPartname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load cbBatchNumber
            cbBatchNumber.DisplayMember = "BatchNumber";
            cbBatchNumber.DisplayMember = "ID";
            cbBatchNumber.DataSource = (from x in db.OrderItems 
                                        join  y in db.Parts on x.PartID equals y.ID
                                       select x).ToList();
            cbBatchNumber.SelectedIndex = -1;
        }
    }
}
