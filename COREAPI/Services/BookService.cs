using COREAPI.DATA;
using COREAPI.DATA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace COREAPI.Services
{
    public class BookService : IBookService
    {
        private BookDBContext _context;
        public BookService(BookDBContext context)
        {
            _context = context;
        }



        public void AddBook(BookViewModel book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            books = _context.Books.ToList();
            return books;
        }

        public Book GetBookById(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        public void UpdateBook(int id, BookViewModel book)
        {
            var _book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (_book != null)
            {
                _book.DateRead = book.DateRead;
                _book.IsRead = book.IsRead;
                _book.Author = book.Author;
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.CoverUrl = book.CoverUrl;
                _book.DateAdded = book.DateAdded;
                _context.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            var _book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Remove(_book);
            _context.SaveChanges();
        }
    }
}
