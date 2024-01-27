using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;
        internal DbSet<T> Set;

        public Repository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.Set = dbContext.Set<T>();
        }
        public void Add(T item)
        {
            Set.Add(item);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = Set;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = Set;
            return query.ToList();
        }

        public void Remove(T item)
        {
            Set.Remove(item);
        }

        public void RemoveRange(IEnumerable<T> items)
        {
            Set.RemoveRange(items);
        }
    }
}
