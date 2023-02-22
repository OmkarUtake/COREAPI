using COREAPI.DATA;
using COREAPI.DATA.ViewModel;
using System.Collections.Generic;

namespace COREAPI.Services
{
    public interface IBookService
    {
        void AddBook(BookViewModel book);
        void DeleteBook(int id);
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(int id, BookViewModel book);
    }
}