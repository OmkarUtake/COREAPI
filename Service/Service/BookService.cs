using CORE.Model.DTO;
using COREAPI.DATA;
using DALayer.IRepository;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;
        public BookService(IBookRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _repo.GetAll();
        }
        public async Task AddBook(Book book)
        {
            await _repo.Add(book);
        }

        public async Task DeleteBook(int id)
        {
            var Bookdata = await _repo.GetById(x => x.Id == id);
            if (Bookdata == null)
            {
                throw new KeyNotFoundException();
            }
            await _repo.Delete(x => x.Id == id);
        }


        public async Task<Book> GetBookById(int id)
        {
            var Bookdata = await _repo.GetById(x => x.Id == id);
            if (Bookdata == null)
            {
                throw new KeyNotFoundException();
            }
            return Bookdata;
        }

        public async Task UpdateBook(int id, Book book)
        {
            await _repo.Update(id, book);
        }

        public async Task<List<Book>> SearchByName(string name)
        {
            List<Book> book = await _repo.SearchBookByName(name);
            if (book == null)
            {
                throw new KeyNotFoundException();
            }
            return book;
        }
    }
}
