using COREAPI.DATA;
using System.Collections.Generic;

namespace DALayer.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {

        Book SearchBookByName(string name);


    }
}
