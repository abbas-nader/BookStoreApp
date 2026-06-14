using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp.UI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            frmSale frmSale = new frmSale();
            frmSale.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            frmBookManagement frmBookManagement = new frmBookManagement();
            frmBookManagement.ShowDialog();
        }

        private void btnDiscountCode_Click(object sender, EventArgs e)
        {
            frmDiscountManagement frmDiscountManagement = new frmDiscountManagement();
            frmDiscountManagement.ShowDialog();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerManagement frmCustomerManagement = new frmCustomerManagement();
            frmCustomerManagement.ShowDialog();
        }
    }
}
