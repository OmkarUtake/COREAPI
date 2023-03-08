using CORE.Model.Model;
using DALayer.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CORE.Database.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> SearchUserByName(string name);
    }
}
