using BusinessObject;
using DataAccess.Repository;
using System;

using System.Windows.Forms;

namespace CarRentingManagementWinApp_DOHOANGANH
{
    public partial class frmCustomerDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public ICustomerRepository customerRepository { get; set; }
        public Customer customerInfo { get; set; }

        public frmCustomerDetails()
        {
            InitializeComponent();
        }
        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate) // Insert
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;

            }
            else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtCustomerID.Enabled = false;

                txtCustomerID.Text = customerInfo.CustomerID.ToString();
                txtCustomerName.Text = customerInfo.CustomerName;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    CustomerID = customerInfo.CustomerID,
                    CustomerName = txtCustomerName.Text,

                };
                customerRepository.UpdateCustomer(customer);
                MessageBox.Show("Update successfully!!", "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Text = customer.CustomerName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    CustomerID = int.Parse(txtCustomerID.Text),
                    CustomerName = txtCustomerName.Text,

                };
                customerRepository.AddCustomer(customer);
                MessageBox.Show("Add successfully!!", "Add new customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtActors_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
