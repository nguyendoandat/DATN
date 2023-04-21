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
    public interface IUserService
    {
        PagedResult<UserDTO> GetAllUser(int pageNumber,int pageSize, Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "");
        IEnumerable<UserDTO> GetUser(Func<IQueryable<AppUser>, IQueryable<AppUser>> filterFull = null, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "");
        UserDTO GetUserById(string id);
        void  InsertUser(UserDTO user);
        Task UpdateUser(UserDTO user);
        void DeleteUser(UserDTO user);
        void DeleteUserById(string id);

    }
}
