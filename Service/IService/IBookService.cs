using CORE.Model.DTO;
using COREAPI.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
        Task AddBook(Book book);
        Task UpdateBook(int id, Book book);
        Task DeleteBook(int id);
        Task<Book> GetBookById(int id);
        Task<List<Book>> SearchByName(string name);
    }
}
