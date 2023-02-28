using CORE.Model.Model;
using DALayer.IRepository;
using System.Collections.Generic;

namespace CORE.Database.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> SearchUserByName(string name);
    }
}
