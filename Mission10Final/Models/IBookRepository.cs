using System;
using System.Linq;

namespace Mission10Final.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }

        // Save a book info after editing
        public void SaveBook(Book b);

        // Creating a new book info and save it in the book repo
        public void CreateBook(Book b);

        // Delete a book
        public void DeleteBook(Book b);
    }
}
