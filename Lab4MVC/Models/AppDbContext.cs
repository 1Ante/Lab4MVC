using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4MVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<CustomerBook> CustomerBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Customer
            modelBuilder.Entity<Customer>().
                HasData(new Customer
                {
                    CustomerId = 1,
                    FirstName = "Johan",
                    LastName = "Svensson",
                    Address = "Blåbärsvägen 1",
                    Phone = "089876543"
                });
            modelBuilder.Entity<Customer>().
                HasData(new Customer
                {
                    CustomerId = 2,
                    FirstName = "Mikael",
                    LastName = "Johansson",
                    Address = "Svartvinbärsvägen 3",
                    Phone = "088876543"
                });
            modelBuilder.Entity<Customer>().
                HasData(new Customer
                {
                    CustomerId = 3,
                    FirstName = "Anna",
                    LastName = "Persson",
                    Address = "Hallonvägen 10",
                    Phone = "088876543"
                });
            modelBuilder.Entity<Customer>().
                HasData(new Customer
                {
                    CustomerId = 4,
                    FirstName = "Ingrid",
                    LastName = "Karlsson",
                    Address = "Päronvägen 15",
                    Phone = "087576443"
                });
            modelBuilder.Entity<Customer>().
                HasData(new Customer
                {
                    CustomerId = 5,
                    FirstName = "Per",
                    LastName = "Bergström",
                    Address = "Lingonvägen 25",
                    Phone = "089375423"
                });


            //Seed Books
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 1,
                    Title = "Astronomiska upptäckter",
                    Description = "En bok om rymden, planeter, liv i universum, stjärnor med mera.",
                    BorrowTime = "2022-06-20",
                    IsBorrowed = true
                });
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 2,
                    Title = "Enkla matrecept",
                    Description = "En bok med recept på maträtter som går snabbt att laga och är billiga.",
                    BorrowTime = "",
                    IsBorrowed = false
                });
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 3,
                    Title = "Matematik C",
                    Description = "Gymnasieskolans matematik-kurs på C-nivå.",
                    BorrowTime = "2022-06-25",
                    IsBorrowed = true
                });
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 4,
                    Title = "Programmering i C#",
                    Description = "Lärobok i programering i språket C#.",
                    BorrowTime = "2022-06-30",
                    IsBorrowed = true
                });
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 5,
                    Title = "Mordet i Örnsköldsvik",
                    Description = "En spännade kriminalroman om ett mord i Örnsköldsvik.",
                    BorrowTime = "2022-06-18",
                    IsBorrowed = true
                });
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 6,
                    Title = "NHL genom tiderna",
                    Description = "En bok om hockeyligan NHL genom tiderna.",
                    BorrowTime = "",
                    IsBorrowed = false
                });
            modelBuilder.Entity<Book>().
                HasData(new Book
                {
                    BookId = 7,
                    Title = "Programmering i Python",
                    Description = "En bok om programmering i programspråket Python.",
                    BorrowTime = "2022-06-29",
                    IsBorrowed = true
                });


            //SEED CUSTOMER-BOOKS
            modelBuilder.Entity<CustomerBook>().
               HasData(new CustomerBook
               {
                   CustomerBookId = 1,
                   CustomerId = 1,
                   BookId = 1
               });
            modelBuilder.Entity<CustomerBook>().
                HasData(new CustomerBook
                {
                    CustomerBookId = 2,
                    CustomerId = 2,
                    BookId = 5
                });
            modelBuilder.Entity<CustomerBook>().
                HasData(new CustomerBook
                {
                    CustomerBookId = 3,
                    CustomerId = 3,
                    BookId = 7
                });
            modelBuilder.Entity<CustomerBook>().
                HasData(new CustomerBook
                {
                    CustomerBookId = 4,
                    CustomerId = 1,
                    BookId = 4,
                });
            modelBuilder.Entity<CustomerBook>().
                HasData(new CustomerBook
                {
                    CustomerBookId = 5,
                    CustomerId = 2,
                    BookId = 3
                });

        }
    }
}
