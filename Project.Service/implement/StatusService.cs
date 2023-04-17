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
	public class StatusService : IStatusService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StatusService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Status> GetStatus(Func<IQueryable<Status>, IQueryable<Status>> filterFull = null, Expression<Func<Status, bool>> filter = null, Func<IQueryable<Status>, IOrderedQueryable<Status>> orderBy = null, string includeProperties = "")
		{
            return ConvertModelToModelViewList((List<Status>)_unitOfWork.GenericRepository<Status>().GetAll(filterFull, filter, orderBy, includeProperties));

        }
        private List<Status> ConvertModelToModelViewList(List<Status> list)
        {
            return list.Select(x => x).ToList();
        }
    }
}
