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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public OrderDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
           
        }

        public void Create(OrderDetailDTO orderDetailDTO)
        {

            var model=_mapper.Map<OrderDetail>(orderDetailDTO);
            _unitOfWork.GenericRepository<OrderDetail>().Insert(model);
            _unitOfWork.Save();
        }

        public IEnumerable<OrderDetailDTO> GetOrderDetail(Func<IQueryable<OrderDetail>, IQueryable<OrderDetail>> filterFull = null, Expression<Func<OrderDetail, bool>> filter = null, Func<IQueryable<OrderDetail>, IOrderedQueryable<OrderDetail>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<OrderDetail>)_unitOfWork.GenericRepository<OrderDetail>().GetAll(filterFull, filter, orderBy, includeProperties));

        }
        private List<OrderDetailDTO> ConvertModelToModelViewList(List<OrderDetail> list)
        {
            return list.Select(x => _mapper.Map<OrderDetailDTO>(x)).ToList();
        }
    }
}
