using Lab4MVC.Models;
using Lab4MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        //private readonly IBookRepository _bookRepository;        

        public CustomerController(ICustomerRepository customerRepo)
        {
            _customerRepository = customerRepo;
            //_bookRepository = bookRepo;          
        }

        public IActionResult List()
        {
            var customerListViewModel = new CustomerListViewModel();
            customerListViewModel.Customers = _customerRepository.GetAllCustomers;            

            return View(customerListViewModel);
        }

        public IActionResult Details(int id)
        {
            var customer = _customerRepository.GetCustomers.FirstOrDefault(c => c.CustomerId == id);

            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }    

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _customerRepository.DeleteAsync(id);
            
            if(result == null)
            {
                return BadRequest("Something went wrong...");
            }                
            return RedirectToAction("List");       
        }

        public IActionResult AddCustomer(string txtFirstName, string txtLastName, string txtAddress, string txtPhone)
        {
            _customerRepository.AddCustomer(txtFirstName, txtLastName, txtAddress, txtPhone);
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            var result = _customerRepository.GetCustomerById(id);
            
            if (ModelState.IsValid)
            {
                await _customerRepository.EditCustomer(customer);
                return RedirectToAction("List");
            }
            return View(result);
           
        }
        
    }    
}
