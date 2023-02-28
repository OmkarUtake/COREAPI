using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DALayer.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly BookDBContext _db;

        public BookRepository(BookDBContext db) : base(db)
        {
            _db = db;
        }

        public List<Book> SearchBookByName(string name)
        {
            var model = _db.Books.Where(x => x.Title == name).ToList();
            return model;
        }
    }
}
