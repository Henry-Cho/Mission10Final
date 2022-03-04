using System;
using System.Linq;

namespace Mission10Final.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookContext context { get; set; }
        public EFBookRepository(BookContext _context)
        {
            context = _context;
        }
        // Create a IQuerayble instance (Books type) which has an instance of BookContext
        public IQueryable<Book> Books => context.Books;

        // Save a book info after edition
        public void SaveBook(Book b)
        {
            // Save the corresponding changes
            context.SaveChanges();
        }

        // Create a new book and add it into the repo
        public void CreateBook(Book b)
        {
            // Add a book info to the database
            context.Add(b);
            // Save changes
            context.SaveChanges();
        }

        // Delete a book
        public void DeleteBook(Book b)
        {
            // Remove a certain book out of repo
            context.Remove(b);
            // Save changes
            context.SaveChanges();
        }
    }
}
