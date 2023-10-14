using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomersList();
        public Customer Login(string Email, String Password);
        public void AddCustomer(Customer cartoon);
        public void UpdateCustomer(Customer cartoon);
        public void DeleteCustomer(int CustomerID);
    }
}
