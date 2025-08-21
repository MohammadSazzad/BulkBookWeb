using System;
using System.Linq.Expressions;
using Bulk.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulk.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        internal DbSet<T> dbSet => _context.Set<T>();
        public Repository(DbContext context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.ToList();
        }

        public T? Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
