using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }      

        Book GetBookById(int bookId);

    }

}

