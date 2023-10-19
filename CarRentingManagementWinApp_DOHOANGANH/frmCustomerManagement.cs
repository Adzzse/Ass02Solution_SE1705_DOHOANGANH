using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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

        bool search = false;
        bool filter = false;
        IEnumerable<Customer> dataSource;
        IEnumerable<Customer> searchResult;
        IEnumerable<Customer> filterResult;

        IEnumerable<string> countryList;

        public frmCustomerManagement() => InitializeComponent();

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            txtCustomerId.Enabled = false;
            txtCustomerName.Enabled = false;
            txtTelephone.Enabled = false;
            txtEmail.Enabled = false;
            dtpBirthday.Enabled = false;
            txtStatus.Enabled = false;

            btnNew.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnLoad.Enabled = true;
            grSearch.Enabled = false;

            dgvCustomerList.Enabled = false;
        }

        public void LoadCustomerList()
        {
            try
            {
                var customerList = customerRepository.GetCustomersList();
                BindingSource source = new BindingSource();
                source.DataSource = customerList;

                txtCustomerId.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtTelephone.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                dtpBirthday.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                //                txtPassword.DataBindings.Clear();

                txtCustomerId.DataBindings.Add("Text", source, "CustomerId");
                txtCustomerName.DataBindings.Add("Text", source, "CustomerName");
                txtTelephone.DataBindings.Add("Text", source, "Telephone");
                txtEmail.DataBindings.Add("Text", source, "Email");
                dtpBirthday.DataBindings.Add("Text", source, "CustomerBirthday");
                txtStatus.DataBindings.Add("Text", source, "CustomerStatus");

                dgvCustomerList.DataSource = null;
                dgvCustomerList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of customers");
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {

            btnNew.Enabled = true;
            dgvCustomerList.Enabled = true;
            btnLoad.Enabled = true;
            grSearch.Enabled = true;
            btnDelete.Enabled = true;
            LoadCustomerList();
        }

        private void ClearText()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
            dtpBirthday.Text = "";
            txtStatus.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "&New")
            {
                btnNew.Text = "&Cancel";

                txtCustomerId.Enabled = true;
                txtCustomerName.Enabled = true;
                txtTelephone.Enabled = true;
                txtEmail.Enabled = true;
                dtpBirthday.Enabled = true;
                txtStatus.Enabled = true;

                btnSave.Enabled = true;
                // Clear DataBinding
                txtCustomerId.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtTelephone.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                dtpBirthday.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                dgvCustomerList.ClearSelection();
                ClearText();
            }
            else
            {
                btnNew.Text = "&New";
                btnSave.Enabled = false;
                LoadCustomerList();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) ||
                string.IsNullOrEmpty(txtTelephone.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtStatus.Text))
            {
                MessageBox.Show("All fields are required!", "Customer Management",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!byte.TryParse(txtStatus.Text, out byte customerStatus))
                {
                    MessageBox.Show("Please enter a valid numeric Status.", "Customer Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dtpBirthday.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Please select a valid Date of Birth.", "Customer Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var c = new Customer
                {
                    CustomerName = txtCustomerName.Text,
                    Telephone = txtTelephone.Text,
                    Email = txtEmail.Text,
                    CustomerBirthday = dtpBirthday.Value,
                    CustomerStatus = customerStatus
                };
                customerRepository.SaveCustomer(c);

                btnNew.Text = "&New";
                btnSave.Enabled = false;

                LoadCustomerList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Customer Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var c = new Customer
                {
                    CustomerId = int.Parse(txtCustomerId.Text),
                };
                customerRepository.DeleteCustomer(c);
                LoadCustomerList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
