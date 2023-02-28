using CORE.Model.DTO;
using COREAPI.DATA;
using DALayer.IRepository;
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

        public IQueryable<Book> SearchBookByName(string name)
        {

            var data = from x in _db.Books
                       select new Book()
                       {

                           CoverUrl = x.CoverUrl,
                           Author = x.Author,
                       };
            return data;
        }
    }
}
