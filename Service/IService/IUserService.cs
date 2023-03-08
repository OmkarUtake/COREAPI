using CORE.Model.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE.Service.IService
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task Add(User user);
        Task Update(int id, User user);
        Task Delete(int id);
        Task<User> Details(int id);
        Task<List<User>> SearchByName(string name);
    }
}
