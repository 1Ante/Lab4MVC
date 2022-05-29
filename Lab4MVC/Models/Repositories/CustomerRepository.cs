using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers
        {
            get
            {
                return _appDbContext.Customers;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }


        public Customer AddCustomer(string txtFirstName, string txtLastName, string txtAddress, string txtPhone)
        {
            Customer newCustomer = new Customer { FirstName = txtFirstName, LastName = txtLastName, Address = txtAddress, Phone = txtPhone };
            _appDbContext.Customers.Add(newCustomer);
            _appDbContext.SaveChanges();
            return null;
        }


        public async Task<Customer> DeleteAsync(int id)
        {
            var result = await _appDbContext.Customers.
                FirstOrDefaultAsync(c => c.CustomerId == id);
            if (result != null)
            {
                _appDbContext.Customers.Remove(result);
                await _appDbContext.SaveChangesAsync();
                return result;
            }
            return result;

        }

        public async Task<Customer> EditCustomer(Customer customer)
        {
            var result = GetCustomerById(customer.CustomerId);
            if (result != null)
            {
                result.FirstName = customer.FirstName;
                result.LastName = customer.LastName;
                result.Address = customer.Address;
                result.Phone = customer.Phone;

                await _appDbContext.SaveChangesAsync();
            }

            return null;
        }

        public IEnumerable<Customer> GetCustomers =>        
            _appDbContext.Customers.Include(c => c.CustomerBooks).ThenInclude(b => b.Book);
        
    }
}
