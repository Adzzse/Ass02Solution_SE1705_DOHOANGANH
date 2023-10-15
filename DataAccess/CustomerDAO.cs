using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static object instanceLook = new object();
        public List<Customer> GetCustomersList => customers;





        // Initialize CustomerList
        private static List<Customer> customers = new List<Customer>
        {
            new Customer()
            {
                CustomerID = 1,
                CustomerName=""
            }
        };



        public Customer Login(string providedEmail, string providedPassword)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string emailFromConfig = config["AdminAccount:Email"];
            string passwordFromConfig = config["AdminAccount:Password"];

            if (providedEmail.Equals(emailFromConfig) && providedPassword.Equals(passwordFromConfig))
            {
                // Login successful, create and return a Customer object
                return new Customer
                {
                    CustomerID = 1,
                    CustomerName = "Admin"
                };
            }
            // Login failed, return null
            return null;
        }



        // GetCustomer
        public Customer GetCustomer(int CustomerID)
        {
            return customers.SingleOrDefault(mb => mb.CustomerID == CustomerID);
        }
        public Customer GetCustomer(string ShortDescription)
        {
            return customers.SingleOrDefault(mb => mb.CustomerName.Equals(ShortDescription));
        }

        public static List<Customer> GetProducts()
        {
            var customers = new List<Customer>();
            try
            {
                using var db = new FUCarRentingManagementContext();
                customers = db.Customers.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return customers;
        }








        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        public void AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is undefined!!");
            }

            if (GetCustomer(customer.CustomerID) == null && GetCustomer(customer.CustomerName) == null)
            {
                customers.Add(customer);
            }
            else
            {
                throw new Exception("Customer is existed!!");
            }
        }
        public void Update(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer is undefined!!");
            }
            Customer cus = GetCustomer(customer.CustomerID);
            if (cus != null)
            {
                var index = customers.IndexOf(cus);
                customers[index] = customer;
            }
            else
            {
                throw new Exception("Customer does not exist!!");
            }
        }

        public static void UpdateProduct(Customer customer)
        {
            try
            {
                using var db = new MyDbContext();
                db.Entry<Customer>(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void Delete(int CustomerId)
        {
            Customer customer = GetCustomer(CustomerId);
            if (customer != null)
            {
                customers.Remove(customer);
            }
            else
            {
                throw new Exception("Customer does not exist!!");
            }
        }
    }
}
