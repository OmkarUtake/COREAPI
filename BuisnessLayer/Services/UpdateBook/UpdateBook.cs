using COREAPI.DATA.ViewModel;
using COREAPI.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services.UpdateBook
{
    public class UpdateBook : IUpdateBook
    {
        private readonly BookDBContext _context;
        public UpdateBook(BookDBContext context)
        {
            _context = context;
        }

        public void EditDetail(int id, BookViewModel book)
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
    }
}
