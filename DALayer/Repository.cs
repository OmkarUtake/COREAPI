using COREAPI.DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddBook(T book)
        {
            _dbSet.Add(book);
        }

        public void DeleteBook(int id)
        {
            T model = _dbSet.Find(id);
            _dbSet.Remove(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public T GetBookById(int id)
        {
            var model = _dbSet.Find(id);
            return model;
        }

        public void UpdateBook(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
