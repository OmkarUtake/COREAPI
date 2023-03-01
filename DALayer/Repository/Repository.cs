using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DALayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookDBContext _db;

        public Repository(BookDBContext db)
        {
            _db = db;
        }

        public async Task<List<T>> GetAll()
        {
            var data = await _db.Set<T>().ToListAsync();
            return data;
        }

        public async Task<T> GetById(Expression<Func<T, bool>> expression)
        {
            return await _db.Set<T>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task Add(T model)
        {
            _db.Add(model);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Expression<Func<T, bool>> experssion)
        {
            var data = await _db.Set<T>().Where(experssion).FirstOrDefaultAsync();
            _db.Set<T>().Remove(data);
            await _db.SaveChangesAsync();
        }

        public async Task Update(int id, T model)
        {
            _db.Update(model);
            await _db.SaveChangesAsync();
        }
    }
}
