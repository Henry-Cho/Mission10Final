using System;
using Microsoft.EntityFrameworkCore;

namespace Mission10Final.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
        }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }   

        public DbSet<Book> Books { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }
    }
}
