using CORE.Database.IRepository;
using CORE.Model.Model;
using CORE.Service.IService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE.Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task Add(User user)
        {
            if (user == null)
            {
                throw new System.Exception();
            }
            await _userRepo.Add(user);
        }

        public async Task Delete(int id)
        {
            var data = await _userRepo.GetById(x => x.Id == id);
            if (data == null)
            {
                throw new KeyNotFoundException();
            }
            await _userRepo.Delete(x => x.Id == id);
        }

        public async Task<User> Details(int id)
        {
            var data = await _userRepo.GetById(x => x.Id == id);
            return data;
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepo.GetAll();
        }

        public async Task<List<User>> SearchByName(string name)
        {
            var users = await _userRepo.SearchUserByName(name);
            return users;
        }

        public async Task Update(int id, User user)
        {
            await _userRepo.Update(id, user);
        }
    }
}
