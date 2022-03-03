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

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
