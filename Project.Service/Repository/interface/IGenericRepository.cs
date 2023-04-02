using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public IEnumerable<T> GetAll(
            Func<IQueryable<T>, IQueryable<T>> filterFull = null,
            Expression<Func<T,bool>> filter=null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy=null,
            string includeProperties="");
        public T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(object id);
    }
}
