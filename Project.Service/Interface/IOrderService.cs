using Project.Data.Entities;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interface
{
    public interface IOrderService
    {
        PagedResult<OrderDTO> GetAllOrder(int pageNumber, int pageSize, Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "");

        IEnumerable<OrderDTO> GetOrder(Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "");
        OrderDTO GetByOrderId(int id);
        int Create(OrderDTO order);
        void UpdateOrder(OrderDTO order);
    }
}
