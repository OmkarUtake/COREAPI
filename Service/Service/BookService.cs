using COREAPI.DATA;
using DALayer.IRepository;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }

        public IQueryable<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }
        public void AddBook(Book book)
        {
            _repo.Add(book);
        }

        public void DeleteBook(Book bk)
        {
            _repo.Delete(x => x.Id.Equals(bk.Id));
        }


        public Book GetBookById(Book book)
        {
            return _repo.GetById(x => x.Id.Equals(book)).FirstOrDefault();
        }

        public void UpdateBook(int id, Book book)
        {
            _repo.Update(id, book);
        }

        public List<Book> SearchByName(string name)
        {
            List<Book> book = _repo.SearchBookByName(name);
            return book;
        }
    }
}
