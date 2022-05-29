using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        

        public IEnumerable<Book> GetAllBooks
        {
            get
            {
                return _appDbContext.Books;
            }
        }

        public Book GetBookById(int bookId)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BookId == bookId);
        }      
              
    }
}
