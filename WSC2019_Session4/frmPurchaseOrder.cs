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
        private List<Dictionary<string, object>> dataTable;
        public frmPurchaseOrder()
        {
            InitializeComponent();
            db = new Session4Entities();
            dataTable = new List<Dictionary<string, object>>();
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
        }

        private void LoadDataTable()
        {
            List<dynamic> listO = new List<dynamic>();
            listO = db.SP_GetdgvPurchaseOrder().ToList<dynamic>();
            for (int i = 0; i < listO.Count; i++)
            {
                dynamic o = listO[i];
                Dictionary<string, object> one = new Dictionary<string, object>() {
                    {"PartName",o.PartName.ToString() },
                    {"BatchNumber",o.BatchNumber.ToString() },
                    {"Amount",o.Amount.ToString() },
                    {"ID",i.ToString() }
                };
                dataTable.Add(one);
            }

            for (int i = 0; i < dataTable.Count; i++)
            {
                Dictionary<string, object> one = dataTable[i];
                dgvPurchaseOrder.Rows.Add(one["PartName"], one["BatchNumber"], one["Amount"], "Remove", one["ID"]);
            }
        }
    }
}
