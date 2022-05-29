using Lab4MVC.Models;
using Lab4MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Controllers
{
    public class BookController : Controller
    {       
       
        private readonly IBookRepository _bookRepository;        

        public BookController(IBookRepository bookRepo)
        {
            _bookRepository = bookRepo;            
        }        

        public IActionResult List()
        {
            var customerListViewModel = new CustomerListViewModel();
            customerListViewModel.Books = _bookRepository.GetAllBooks;

            return View(customerListViewModel);
        }     

        public IActionResult Details(int Id)
        {
            var details = _bookRepository.GetBookById(Id);
            if (details == null)
            {
                return NotFound();
            }
            return View(details);
        }

    }
}
