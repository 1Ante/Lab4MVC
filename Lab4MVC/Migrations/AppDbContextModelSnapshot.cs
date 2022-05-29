﻿// <auto-generated />
using Lab4MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab4MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab4MVC.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BorrowTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsBorrowed")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BorrowTime = "2022-06-20",
                            Description = "En bok om rymden, planeter, liv i universum, stjärnor med mera.",
                            IsBorrowed = true,
                            Title = "Astronomiska upptäckter"
                        },
                        new
                        {
                            BookId = 2,
                            BorrowTime = "",
                            Description = "En bok med recept på maträtter som går snabbt att laga och är billiga.",
                            IsBorrowed = false,
                            Title = "Enkla matrecept"
                        },
                        new
                        {
                            BookId = 3,
                            BorrowTime = "2022-06-25",
                            Description = "Gymnasieskolans matematik-kurs på C-nivå.",
                            IsBorrowed = true,
                            Title = "Matematik C"
                        },
                        new
                        {
                            BookId = 4,
                            BorrowTime = "2022-06-30",
                            Description = "Lärobok i programering i språket C#.",
                            IsBorrowed = true,
                            Title = "Programmering i C#"
                        },
                        new
                        {
                            BookId = 5,
                            BorrowTime = "2022-06-18",
                            Description = "En spännade kriminalroman om ett mord i Örnsköldsvik.",
                            IsBorrowed = true,
                            Title = "Mordet i Örnsköldsvik"
                        },
                        new
                        {
                            BookId = 6,
                            BorrowTime = "",
                            Description = "En bok om hockeyligan NHL genom tiderna.",
                            IsBorrowed = false,
                            Title = "NHL genom tiderna"
                        },
                        new
                        {
                            BookId = 7,
                            BorrowTime = "2022-06-29",
                            Description = "En bok om programmering i programspråket Python.",
                            IsBorrowed = true,
                            Title = "Programmering i Python"
                        });
                });

            modelBuilder.Entity("Lab4MVC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Blåbärsvägen 1",
                            FirstName = "Johan",
                            LastName = "Svensson",
                            Phone = "089876543"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Svartvinbärsvägen 3",
                            FirstName = "Mikael",
                            LastName = "Johansson",
                            Phone = "088876543"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Hallonvägen 10",
                            FirstName = "Anna",
                            LastName = "Persson",
                            Phone = "088876543"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "Päronvägen 15",
                            FirstName = "Ingrid",
                            LastName = "Karlsson",
                            Phone = "087576443"
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "Lingonvägen 25",
                            FirstName = "Per",
                            LastName = "Bergström",
                            Phone = "089375423"
                        });
                });

            modelBuilder.Entity("Lab4MVC.Models.CustomerBook", b =>
                {
                    b.Property<int>("CustomerBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CustomerBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerBooks");

                    b.HasData(
                        new
                        {
                            CustomerBookId = 1,
                            BookId = 1,
                            CustomerId = 1
                        },
                        new
                        {
                            CustomerBookId = 2,
                            BookId = 5,
                            CustomerId = 2
                        },
                        new
                        {
                            CustomerBookId = 3,
                            BookId = 7,
                            CustomerId = 3
                        },
                        new
                        {
                            CustomerBookId = 4,
                            BookId = 4,
                            CustomerId = 1
                        },
                        new
                        {
                            CustomerBookId = 5,
                            BookId = 3,
                            CustomerId = 2
                        });
                });

            modelBuilder.Entity("Lab4MVC.Models.CustomerBook", b =>
                {
                    b.HasOne("Lab4MVC.Models.Book", "Book")
                        .WithMany("CustomerBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab4MVC.Models.Customer", "Customer")
                        .WithMany("CustomerBooks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
