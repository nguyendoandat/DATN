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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void DeleteUser(UserDTO user)
        {
            var model = _mapper.Map<AppUser>(user);
            _unitOfWork.GenericRepository<AppUser>().Delete(model);
            _unitOfWork.Save();
        }

        public void DeleteUserById(string id)
        {
            _unitOfWork.GenericRepository<AppUser>().DeleteById(id);
            _unitOfWork.Save();
        }

        public PagedResult<UserDTO> GetAllUser(int pageNumber, int pageSize, Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<UserDTO> vmList = new List<UserDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<AppUser>().GetAll( filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<AppUser>().GetAll( filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }
            return new PagedResult<UserDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<UserDTO> GetUser(Expression<Func<AppUser, bool>> filter = null, Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<AppUser>) _unitOfWork.GenericRepository<AppUser>().GetAll(filter, orderBy, includeProperties));
        }

        public UserDTO GetUserById(string id)
        {
            return _mapper.Map<UserDTO>(_unitOfWork.GenericRepository<AppUser>().GetById(id));
        }

        public void InsertUser(UserDTO user)
        {
            var model=_mapper.Map<AppUser>(user);
            _unitOfWork.GenericRepository<AppUser>().Insert(model);
            _unitOfWork.Save();
        }

        public void UpdateUser(UserDTO user)
        {
            var model = _mapper.Map<AppUser>(user);
            _unitOfWork.GenericRepository<AppUser>().Update(model);
            _unitOfWork.Save();
        }
        private List<UserDTO> ConvertModelToModelViewList(List<AppUser> list)
        {
            return list.Select(x => _mapper.Map<UserDTO>(x)).ToList();
        }
    }
}
