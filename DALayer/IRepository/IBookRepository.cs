using COREAPI.DATA;
using System.Linq;

namespace DALayer.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        IQueryable<Book> SearchBookByName(string name);
    }
}
