using COREAPI.DATA;
using System.Linq;

namespace BuisnessLayer.Services.DeleteBook
{
    public class DeleteBook : IDeleteBook
    {
        private readonly BookDBContext _context;
        public DeleteBook(BookDBContext context)
        {
            _context = context;
        }

        public void RemoveBook(int id)
        {
            var _book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Remove(_book);
            _context.SaveChanges();
        }
    }
}
