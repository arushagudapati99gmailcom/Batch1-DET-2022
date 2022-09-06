using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.Models.MyCode;

namespace Batch1_DET_2022.Data
{
    public class BookContext:DbContext
    {
        public BookContext()
        {

        }
        public BookContext(DbContextOptions<BookContext> options) 
            : base(options)

        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        //public virtual DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=BG4WS1801\\SQLEXPRESS;Database=traningTSQL;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Book>()
        //    //    .Property(b => b.price)
        //    //    .IsRequired() //[Required]
        //    //    .HasColumnName("BKprice")
        //    //    .HasDefaultValue(200);
        //}


      

        

        }
}
