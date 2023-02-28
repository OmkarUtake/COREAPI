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
        void DeleteBook(Book bk);
        Book GetBookById(Book book);
    }
}
