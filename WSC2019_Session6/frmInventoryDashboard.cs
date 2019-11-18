using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSC2019_Session6
{
    public partial class frmInventoryDashboard : Form
    {
        public frmInventoryDashboard()
        {
            InitializeComponent();
        }
        private void frmInventoryDashboard_Load(object sender, EventArgs e)
        {
            cbLanguage.Items.Add("English");
            cbLanguage.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
