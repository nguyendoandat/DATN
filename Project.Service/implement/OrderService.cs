using AutoMapper;
using Project.Data.Entities;
using Project.Service.Interface;
using Project.Service.Repository;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
