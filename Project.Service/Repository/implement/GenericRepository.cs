using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Repository.implement
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _dbcontext;
        private DbSet<T> _dbSet;
        public GenericRepository(AppDbContext dbcontex)
        {
            _dbcontext = dbcontex;
            _dbSet=_dbcontext.Set<T>();

        }
        public void Delete(T entity)
        {
            if (_dbcontext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public void DeleteById(object id)
        {
            var entity=_dbSet.Find(id);
            Delete(entity);
        }

        public IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> filterFull = null, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;
            if (filterFull != null)
            {
                query = filterFull(query);
            }
            if (filter != null)
            {
                query= query.Where(filter);
            }
            foreach(var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if(orderBy != null)
            {
                return orderBy(query).AsNoTracking().ToList();
            }
            else
            {
                return query.AsNoTracking().ToList();
            }
            _dbcontext.Entry(query).State = EntityState.Detached;
        }

        public T GetById(object id)
        {
            
            var entity= _dbSet.Find(id);
            _dbcontext.Entry(entity).State= EntityState.Detached;
            return entity;
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbcontext.Entry(entity).State= EntityState.Modified;
        }
    }
}
