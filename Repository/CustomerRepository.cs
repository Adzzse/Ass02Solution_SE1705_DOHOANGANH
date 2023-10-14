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
            return CustomerDAO.Instance.GetCustomersList;
        }
        public Customer Login(string Email, string Password)
        {
            return CustomerDAO.Instance.Login(Email, Password);
        }
        public void AddCustomer(Customer cartoon) => CustomerDAO.Instance.AddCustomer(cartoon);

        public void DeleteCustomer(int CustomerID) => CustomerDAO.Instance.Delete(CustomerID);

        public void UpdateCustomer(Customer cartoon) => CustomerDAO.Instance.Update(cartoon);

    }
}
