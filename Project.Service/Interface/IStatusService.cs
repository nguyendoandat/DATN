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
	public interface IStatusService
	{
        IEnumerable<Status> GetStatus(Func<IQueryable<Status>, IQueryable<Status>> filterFull = null, Expression<Func<Status, bool>> filter = null, Func<IQueryable<Status>, IOrderedQueryable<Status>> orderBy = null, string includeProperties = "");

    }
}
