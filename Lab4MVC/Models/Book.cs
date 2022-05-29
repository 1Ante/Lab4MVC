using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(15)]
        public string Description { get; set; }

        [Required]        
        public string BorrowTime { get; set; }

        [Required]
        public bool IsBorrowed { get; set; }

        public ICollection<CustomerBook> CustomerBooks { get; set; }



    }
}
