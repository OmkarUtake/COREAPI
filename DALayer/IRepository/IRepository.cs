using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DALayer.IRepository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetById(Expression<Func<T, bool>> expression);
        void Add(T book);
        void Update(int id, T model);
        void Delete(Expression<Func<T, bool>> experssion);
    }
}
