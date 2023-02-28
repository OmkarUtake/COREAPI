//using CORE.Database.IRepository;
//using CORE.Model.Model;
//using CORE.Service.IService;
//using COREAPI.DATA;
//using DALayer;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CORE.Service.Service
//{
//    public class UserService : IUserService
//    {
//        private readonly IUserRepository _userRepo;
//        public UserService(IUserRepository userRepo)
//        {
//            _userRepo = userRepo;
//        }

//        public void Add(User user)
//        {
//            _userRepo.Add(user);
//        }

//        public void Delete(int id)
//        {
//            _userRepo.Delete(id);
//        }

//        public User Details(int id)
//        {
//            User data = _userRepo.GetById(id);
//            return data;
//        }

//        public IEnumerable<User> GetAll()
//        {
//            return _userRepo.GetAll();
//        }

//        public List<User> SearchByName(string name)
//        {
//            var users = _userRepo.SearchUserByName(name);
//            return users;
//        }

//        public void Update(int id, User user)
//        {
//            _userRepo.Update(id, user);
//        }
//    }
//}
