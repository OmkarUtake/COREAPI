using COREAPI.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        Book GetBookById(int id);
        void UpdateBook(int id,Book book);
        void DeleteBook(int id);
    }
}
