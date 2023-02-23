using COREAPI.DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services.GetBook
{
    public class GetBookDetails : IGetBookById
    {
        private readonly BookDBContext _context;
        public GetBookDetails(BookDBContext context)
        {
            _context = context;
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

    }
}
