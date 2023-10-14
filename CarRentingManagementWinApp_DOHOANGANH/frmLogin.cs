using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingManagementWinApp_DOHOANGANH
{
    public partial class frmLogin : Form
    {
        ICustomerRepository cartoonRepository = new CustomerRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            Customer loginCustomer = cartoonRepository.Login(Email, Password);
            if (loginCustomer != null)
            {
                MessageBox.Show("Login successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomerManagement frmCustomerManagement = null;

                    frmCustomerManagement = new frmCustomerManagement
                    {
                        loginCustomer = loginCustomer,
                    };
                    frmCustomerManagement.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmCustomerManagement.Show();
            }
            else
            {
                if (MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
//frmCustomerManagement