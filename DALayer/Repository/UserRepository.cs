using CORE.Database.IRepository;
using CORE.Model.Model;
using COREAPI.DATA;
using DALayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Database.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly BookDBContext _db;

        public UserRepository(BookDBContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<User>> SearchUserByName(string name)
        {
            var users = await _db.Users.Where(x => x.UserName == name).ToListAsync();
            return users;
        }
    }
}
