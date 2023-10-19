using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        SqlConnection connection;
        SqlCommand command;
        private static CustomerDAO instance = null;
        private static object instanceLook = new object();


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

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            return config["ConnectionStrings:DB"];
        }

        public Customer Login(string providedEmail, string providedPassword)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string emailFromConfig = config["AdminAccount:Email"];
            string passwordFromConfig = config["AdminAccount:Password"];
            string roleFromConfig = config["AdminAccount:Role"];

            if (providedEmail.Equals(emailFromConfig) && providedPassword.Equals(passwordFromConfig))
            {
                // Login successful, create and return a Customer object
                return new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Admin"
                };
            }
            // Login failed, return null
            return null;
        }

        public List<Customer> GetCustomerList()
        {
            var listCustomers = new List<Customer>
            {
            new Customer()
            {
                CustomerId = 1,
                CustomerName=""
            }
        };
            try
            {
                connection = new SqlConnection(GetConnectionString());
                string sqlCommand = "SELECT * FROM Customer";
                command = new SqlCommand(sqlCommand, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection); // Connected Data Access
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        Customer productTemp =
                            new Customer()
                            {
                                CustomerId = reader.GetInt32("CustomerID"),
                                CustomerName = reader.GetString("CustomerName"),
                                Telephone = reader.GetString("Telephone"),
                                Email = reader.GetString("Email"),
                                CustomerBirthday = reader.GetDateTime("CustomerBirthday"),
                                CustomerStatus = reader.GetByte("CustomerStatus"),
                                Password = reader.GetString("Password"),
                            };
                        listCustomers.Add(productTemp);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return listCustomers;
        }



        public void SaveCustomer(Customer c)
        {
            connection = new SqlConnection(GetConnectionString());
            command = new SqlCommand("INSERT INTO Customer(CustomerName, Telephone, Email, CustomerBirthday, CustomerStatus) " +
                "values(@CustomerName, @Telephone, @Email, @CustomerBirthday, @CustomerStatus)", connection);

            command.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = c.CustomerName;
            command.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = c.Telephone;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = c.Email;
            command.Parameters.Add("@CustomerBirthday", SqlDbType.Date).Value = c.CustomerBirthday;
            command.Parameters.Add("@CustomerStatus", SqlDbType.TinyInt).Value = c.CustomerStatus;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCustomer(Customer c)
        {
            connection = new SqlConnection(GetConnectionString());
            string sql = "UPDATE Customers SET CustomerName=@CustomerName, Telephone=@Telephone, " +
                "Email=@Email, CustomerBirthday=@CustomerBirthday, CustomerStatus=@CustomerStatus WHERE CustomerID=@CustomerId";

            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CustomerName", c.CustomerName);
            command.Parameters.AddWithValue("@Telephone", c.Telephone);
            command.Parameters.AddWithValue("@Email", c.Email);
            command.Parameters.AddWithValue("@CustomerBirthday", c.CustomerBirthday);
            command.Parameters.AddWithValue("@CustomerStatus", c.CustomerStatus);
            command.Parameters.AddWithValue("@CustomerId", c.CustomerId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public void DeleteCustomer(Customer c)
        {
            connection = new SqlConnection(GetConnectionString());
            string sql = "DELETE Customer WHERE CustomerID=@CustomerId";

            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CustomerId", c.CustomerId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
