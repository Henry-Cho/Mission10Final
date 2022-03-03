using System;
using System.Linq;

namespace Mission10Final.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
