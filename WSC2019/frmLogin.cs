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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Session2Entities db = new Session2Entities();
            Employee emp = (from x in db.Employees
                           where txtPassword.Text == x.Password && txtUsername.Text == x.Usernname
                           select x).SingleOrDefault<Employee>();
            if (emp!=null)
            {
                //ADMIN
                if (emp.isAdmin==false)
                {
                    frmEmergencyMaintenanceManagement frmNext = new frmEmergencyMaintenanceManagement();
                    frmNext.username = txtUsername.Text;
                    frmNext.ShowDialog();
                }
                else //USER
                {
                    frmAccessRequesting frmAcc = new frmAccessRequesting();
                    frmAcc.Tag = txtUsername.Text;
                    frmAcc.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
