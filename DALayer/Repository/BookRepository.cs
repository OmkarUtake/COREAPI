

using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALayer.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly BookDBContext _db;

        public BookRepository(BookDBContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<Book>> SearchBookByName(string name)
        {
            var data = await _db.Books
                     .Where(x => x.Title == name)
                     .Select(x => new Book
                     {
                         Id = x.Id,
                         Author = x.Author,
                         CoverUrl = x.CoverUrl,
                         Title = x.Title,
                         Description = x.Description
                     }).ToListAsync();
            return data;
        }

    }
}
