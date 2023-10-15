using BusinessObject;
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
    public partial class frmCustomerManagement : Form
    {
        public Customer loginCustomer { get; set; }
        ICustomerRepository customerRepository = new CustomerRepository();

        BindingSource source;
        BindingSource countrySource;

        bool search = false;
        bool filter = false;
        IEnumerable<Customer> dataSource;
        IEnumerable<Customer> searchResult;
        IEnumerable<Customer> filterResult;

        IEnumerable<string> countryList;

        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtTelephone.Enabled = false;

            txtBirthday.Enabled = false;
            txtEmail.Enabled = false;
            txtStatus.Enabled = false;

            btnNew.Enabled = false;
            dgvCustomerList.Enabled = false;

            btnLoad.Enabled = true;

            grSearch.Enabled = false;
        }

        private Customer GetCustomerInfo()
        {
            Customer customer = null;
            try
            {
                customer = new Customer
                {
                    CustomerID = int.Parse(txtCustomerID.Text),
                    CustomerName = txtCustomerName.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Customer Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return customer;
        }

        private void LoadFullList()
        {
            search = false;
            filter = false;
            var customers = customerRepository.GetCustomersList();
            var customerList = from customer in customers
                               orderby customer.CustomerName descending
                               select customer;
            dataSource = customerList;
            searchResult = customerList;
            filterResult = customerList;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

            btnNew.Enabled = true;
            dgvCustomerList.Enabled = true;
            btnLoad.Enabled = true;
            grSearch.Enabled = true;
            LoadFullList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCustomerDetails frmCustomerDetails = new frmCustomerDetails
            {
                customerRepository = this.customerRepository,
                InsertOrUpdate = true,
                Text = "Add new customer"
            };

            if (frmCustomerDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = GetCustomerInfo();

            if (MessageBox.Show($"Do you really want to delete the customer: \n" +
            $"Customer ID: {customer.CustomerID}\n" +
            $"Customer Name: {customer.CustomerName}\n"
            , "Delete customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerRepository.DeleteCustomer(customer.CustomerID);
                search = false;
                LoadFullList();
            }
        }

        private void dgvCustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = GetCustomerInfo();

            frmCustomerDetails frmCustomerDetails = new frmCustomerDetails
            {
                customerRepository = this.customerRepository,
                InsertOrUpdate = false,
                customerInfo = customer,
                Text = "Update customer info"
            };

            if (frmCustomerDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grSearch_Enter(object sender, EventArgs e)
        {

        }

        private void lbShortDescription_Click(object sender, EventArgs e)
        {

        }

        private void radioByProducer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
