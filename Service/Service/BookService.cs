using COREAPI.DATA;
using DALayer;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository<Book> _repo;
        public BookService(IBookRepository<Book> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }
        public void AddBook(Book book)
        {
            _repo.AddBook(book);
            _repo.Save();
        }

        public void DeleteBook(int id)
        {
            _repo.DeleteBook(id);
            _repo.Save();
        }

        public Book GetBookById(int id)
        {
            return _repo.GetBookById(id);
        }

        public void UpdateBook(int id, Book book)
        {
            _repo.UpdateBook(id, book);
            _repo.Save();
        }
    }
}
