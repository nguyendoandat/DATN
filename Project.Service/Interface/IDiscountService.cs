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
    public interface IDiscountService
    {
        PagedResult<DiscountDTO> GetAllDiscount(int pageNumber, int pageSize, Func<IQueryable<Discount>, IQueryable<Discount>> filterFull = null, Expression<Func<Discount, bool>> filter = null, Func<IQueryable<Discount>, IOrderedQueryable<Discount>> orderBy = null, string includeProperties = "");

        IEnumerable<DiscountDTO> GetDiscount(Func<IQueryable<Discount>, IQueryable<Discount>> filterFull = null, Expression<Func<Discount, bool>> filter = null, Func<IQueryable<Discount>, IOrderedQueryable<Discount>> orderBy = null, string includeProperties = "");
        DiscountDTO GetByDiscountId(int id);
        void InsertDiscount(DiscountDTO discount);
        void UpdateDiscount(DiscountDTO discount);
        void DeleteDiscount(DiscountDTO discount);
        void DeleteDiscountById(int id);
    }
}
