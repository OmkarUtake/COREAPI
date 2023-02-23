using COREAPI.DATA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services.UpdateBook
{
    public interface IUpdateBook
    {
        void EditDetail(int id, BookViewModel book);
    }
}
