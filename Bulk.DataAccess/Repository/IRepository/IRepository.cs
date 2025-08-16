using System;
using System.Linq.Expressions;

namespace Bulk.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T? Get(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
    }
}