using COREAPI.DATA;
using System.Collections.Generic;

namespace DALayer.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> SearchBookByName(string name);
    }
}
