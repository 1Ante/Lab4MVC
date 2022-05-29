using Lab4MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.ViewModels
{
    public class CustomerListViewModel
    {
        
        public IEnumerable<Customer> Customers { get; set; }

        public IEnumerable<Book> Books { get; set; }

        
    }
}
