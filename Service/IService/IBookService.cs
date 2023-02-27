using COREAPI.DATA;
using System.Collections.Generic;

namespace Service.IService
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        Book GetBookById(int id);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
    }
}
