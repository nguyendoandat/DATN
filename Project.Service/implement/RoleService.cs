﻿using Microsoft.AspNetCore.Identity;
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
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<IdentityRole> GetAllRole(Func<IQueryable<IdentityRole>, IQueryable<IdentityRole>> filterFull = null, Expression<Func<IdentityRole, bool>> filter = null, Func<IQueryable<IdentityRole>, IOrderedQueryable<IdentityRole>> orderBy = null, string includeProperties = "")
        {
            return _unitOfWork.GenericRepository<IdentityRole>().GetAll(filterFull, filter, orderBy, includeProperties);
        }

        public IdentityRole GetByRoleId(string id)
        {
            return _unitOfWork.GenericRepository<IdentityRole>().GetById(id);
        }
    }
}
