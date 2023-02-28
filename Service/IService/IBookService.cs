using COREAPI.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Service.IService
{
    public interface IBookService
    {
        IQueryable<Book> GetAllBooks();
        void AddBook(Book book);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
        IQueryable GetBookById(int id);
        List<Book> SearchByName(string name);
    }
}
