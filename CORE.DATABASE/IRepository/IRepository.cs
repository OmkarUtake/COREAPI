using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DALayer.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Expression<Func<T, bool>> expression);
        Task Add(T book);
        Task Update(int id, T model);
        Task Delete(Expression<Func<T, bool>> experssion);
    }
}
