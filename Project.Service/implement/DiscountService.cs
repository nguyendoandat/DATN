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
    public class DiscountService : IDiscountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DiscountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void DeleteDiscount(DiscountDTO discount)
        {
            var model = _mapper.Map<Discount>(discount);
            _unitOfWork.GenericRepository<Discount>().Delete(model);
            _unitOfWork.Save();
        }

        public void DeleteDiscountById(int id)
        {

            _unitOfWork.GenericRepository<Discount>().DeleteById(id);
            _unitOfWork.Save();
        }

        public PagedResult<DiscountDTO> GetAllDiscount(int pageNumber, int pageSize, Func<IQueryable<Discount>, IQueryable<Discount>> filterFull = null, Expression<Func<Discount, bool>> filter = null, Func<IQueryable<Discount>, IOrderedQueryable<Discount>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<DiscountDTO> vmList = new List<DiscountDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Discount>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Discount>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }
            return new PagedResult<DiscountDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public DiscountDTO GetByDiscountId(int id)
        {
            return _mapper.Map<DiscountDTO>(_unitOfWork.GenericRepository<Discount>().GetById(id));
        }

        public IEnumerable<DiscountDTO> GetDiscount(Func<IQueryable<Discount>, IQueryable<Discount>> filterFull = null, Expression<Func<Discount, bool>> filter = null, Func<IQueryable<Discount>, IOrderedQueryable<Discount>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Discount>)_unitOfWork.GenericRepository<Discount>().GetAll(filterFull, filter, orderBy, includeProperties));
        }

        public void InsertDiscount(DiscountDTO discount)
        {
            var model = _mapper.Map<Discount>(discount);
            _unitOfWork.GenericRepository<Discount>().Insert(model);
            _unitOfWork.Save();
        }

        public void UpdateDiscount(DiscountDTO discount)
        {
            var model = _mapper.Map<Discount>(discount);
            _unitOfWork.GenericRepository<Discount>().Update(model);
            _unitOfWork.Save();
        }
        private List<DiscountDTO> ConvertModelToModelViewList(List<Discount> list)
        {
            return list.Select(x => _mapper.Map<DiscountDTO>(x)).ToList();
        }
    }
}
