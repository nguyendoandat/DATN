using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project.Service.implement
{
    public class MyService
    {
        private readonly AppDbContext _dbContext;
        public MyService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<object> GetStatistical(DateTime? fromDate, DateTime? toDate)
        {
            DateTime dt;
            var query = from o in _dbContext.Orders
                        join od in _dbContext.OrderDetails
                        on o.Id equals od.OrderId
                        join p in _dbContext.Products
                        on od.ProductId equals p.Id
                        where o.StatusId==5
                        select new
                        {
                            CreatedDate = o.OrderDate,
                            Quantity = od.Quantity,
                            Price = od.Price,
                            OriginalPrice = p.Price,
                        };
            if (fromDate != null)
            {
                query = query.Where(x => x.CreatedDate >= fromDate);
            }
            if (toDate != null)
            {
                query = query.Where(x => x.CreatedDate < toDate);
            }

            var result = query.GroupBy(x => x.CreatedDate).Select(x => new
            {
                Date = x.Key,
                TotalBuy = x.Sum(y => y.Quantity * y.OriginalPrice),
                TotalSell = x.Sum(y => y.Quantity * y.Price),
            }).Select(x => new
            {
                Date = x.Date,
                DoanhThu = x.TotalSell,
                LoiNhuan = x.TotalBuy
            });

            return result.ToList<object>();
        }
    }
}
