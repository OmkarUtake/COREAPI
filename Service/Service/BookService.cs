﻿using COREAPI.DATA;
using DALayer.IRepository;
using Service.IService;
using System.Collections.Generic;

namespace Service.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }
        public void AddBook(Book book)
        {
            _repo.Add(book);
        }

        public void DeleteBook(int id)
        {
            _repo.Delete(id);
        }

        public Book GetBookById(int id)
        {
            return _repo.GetById(id);
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
