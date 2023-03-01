using COREAPI.DATA;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALayer.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> SearchBookByName(string name);
    }
}
