using CORE.Model.Model;
using System.Collections.Generic;

namespace CORE.Service.IService
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(int id, User user);
        void Delete(int id);
        User Details(int id);
        List<User> SearchByName(string name);
    }
}
