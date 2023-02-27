using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DALayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookDBContext _db;
        private readonly DbSet<T> _dbSet;

        public Repository(BookDBContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public void Add(T book)
        {
            _dbSet.Add(book);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            T model = _dbSet.Find(id);
            _dbSet.Remove(model);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public T GetById(int id)
        {
            var model = _dbSet.Find(id);
            return model;
        }

        public void Update(int id, T model)
        {
            _dbSet.Update(model);
            _db.SaveChanges();
        }


    }
}
