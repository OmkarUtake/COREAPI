using COREAPI.DATA;
using DALayer.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DALayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookDBContext _db;

        public Repository(BookDBContext db)
        {
            _db = db;
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).AsNoTracking();
        }

        public void Add(T model)
        {
            _db.Add(model);
            _db.SaveChanges();
        }

        public void Delete(Expression<Func<T, bool>> experssion)
        {
            var data = _db.Set<T>().Where(experssion).FirstOrDefault();
            _db.Set<T>().Remove(data);
            _db.SaveChanges();
        }

        public void Update(int id, T model)
        {
            _db.Update(model);
            _db.SaveChanges();
        }
    }
}
