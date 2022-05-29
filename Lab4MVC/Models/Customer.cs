using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,15}$",
            ErrorMessage = "Only letters are allowed.")]
        [MaxLength(15)]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{4,15}$",
            ErrorMessage = "Only letters are allowed.")]
        [MaxLength(15)]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''0-9'\s]{10,50}$",
            ErrorMessage = "Only letters and numbers are allowed.")]
        [MaxLength(50)]
        [MinLength(10)]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^[0-9''\s]{9,12}$",
            ErrorMessage = "Only numbers are allowed.")]
        [MaxLength (12)]
        [MinLength(9)]
        public string Phone { get; set; }

        public ICollection<CustomerBook> CustomerBooks { get; set; }
    }
}
