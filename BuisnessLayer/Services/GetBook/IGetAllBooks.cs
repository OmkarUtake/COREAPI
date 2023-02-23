using COREAPI.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services.GetBook
{
    public interface IGetAllBooks
    {
        List<Book> GetAllBooks();
    }

   
}
