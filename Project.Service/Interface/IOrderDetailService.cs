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
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetailDTO> GetOrderDetail(Func<IQueryable<OrderDetail>, IQueryable<OrderDetail>> filterFull = null, Expression<Func<OrderDetail, bool>> filter = null, Func<IQueryable<OrderDetail>, IOrderedQueryable<OrderDetail>> orderBy = null, string includeProperties = "");

        void Create(OrderDetailDTO orderDetailDTO);
    }
}
