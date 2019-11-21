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
    public partial class frmInventoryReport : Form
    {
        private Session4Entities db = new Session4Entities();
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            cbWarehouse.DisplayMember = "Name";
            cbWarehouse.ValueMember = "ID";
            cbWarehouse.DataSource = (from x in db.Warehouses select x).ToList();
            cbWarehouse.SelectedIndex = -1;
        }
    }
}
