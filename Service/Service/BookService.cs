using CORE.Model.DTO;
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

        public void DeleteBook(int id)
        {
            _repo.Delete(x => x.Id == id);
        }


        public IQueryable GetBookById(int id)
        {
            return _repo.GetById(x => x.Id == id);
        }

        public void UpdateBook(int id, Book book)
        {
            _repo.Update(id, book);
        }

        public IQueryable<Book> SearchByName(string name)
        {
            IQueryable<Book> book = _repo.SearchBookByName(name);
            return book;
        }
    }
}
