using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomersList()
        {
            return CustomerDAO.Instance.GetCustomerList();
        }
        public Customer Login(string Email, string Password)
        {
            return CustomerDAO.Instance.Login(Email, Password);
        }
        public void SaveCustomer(Customer c) => CustomerDAO.Instance.SaveCustomer(c);

        public void DeleteCustomer(Customer CustomerId) => CustomerDAO.Instance.DeleteCustomer(CustomerId);

        public void UpdateCustomer(Customer customer) => CustomerDAO.Instance.UpdateCustomer(customer);

    }
}
