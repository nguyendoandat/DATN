using AutoMapper;
using Project.Data.Entities;
using Project.Service.Interface;
using Project.Service.Repository;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.implement
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public int Create(OrderDTO order)
        {
            var model= _mapper.Map<Order>(order);
            _unitOfWork.GenericRepository<Order>().Insert(model);
            _unitOfWork.Save();
            return model.Id;
        }

        public PagedResult<OrderDTO> GetAllOrder(int pageNumber, int pageSize, Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<OrderDTO> vmList = new List<OrderDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Order>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Order>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }
            return new PagedResult<OrderDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public OrderDTO GetByOrderId(int id)
        {
            return _mapper.Map<OrderDTO>(_unitOfWork.GenericRepository<Order>().GetById(id));
        }

        public IEnumerable<OrderDTO> GetOrder(Func<IQueryable<Order>, IQueryable<Order>> filterFull = null, Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Order>)_unitOfWork.GenericRepository<Order>().GetAll(filterFull, filter, orderBy, includeProperties));

        }

        public void UpdateOrder(OrderDTO order)
        {
            var model = _mapper.Map<Order>(order);
            _unitOfWork.GenericRepository<Order>().Update(model);
            _unitOfWork.Save();
        }

        private List<OrderDTO> ConvertModelToModelViewList(List<Order> list)
        {
            return list.Select(x => _mapper.Map<OrderDTO>(x)).ToList();
        }
    }
}
