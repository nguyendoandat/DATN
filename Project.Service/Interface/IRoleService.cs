using Microsoft.AspNetCore.Identity;
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
    public interface IRoleService
    {
        IEnumerable<IdentityRole> GetAllRole(Func<IQueryable<IdentityRole>, IQueryable<IdentityRole>> filterFull = null, Expression<Func<IdentityRole, bool>> filter = null, Func<IQueryable<IdentityRole>, IOrderedQueryable<IdentityRole>> orderBy = null, string includeProperties = "");
        IdentityRole GetByRoleId(string id);
    }
}
