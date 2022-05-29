using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }

        IEnumerable<Customer> GetCustomers { get;  }

        Customer GetCustomerById(int customerId);

        Customer AddCustomer(string txtFirstName, string txtLastName, string txtAddress, string txtPhone);

        Task<Customer> DeleteAsync(int customerId);

        Task<Customer> EditCustomer(Customer customer);
        

    }
}
