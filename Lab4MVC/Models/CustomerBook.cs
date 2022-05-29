using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class CustomerBook
    {
        [Key]
        public int CustomerBookId { get; set; }

        public int CustomerId { get; set; }

        public int BookId { get; set; }

        public Customer Customer { get; set; }
        
        public Book Book { get; set; }
    }
}
