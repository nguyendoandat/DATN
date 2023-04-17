using AutoMapper;
using Project.Data.EF;
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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;   
        }
        public void DeleteCategory(CategoryDTO Category)
        {
             var model=_mapper.Map<Category>(Category);
            _unitOfWork.GenericRepository<Category>().Delete(model);
            _unitOfWork.Save();
        }

        public void DeleteCategoryById(int id)
        {
            _unitOfWork.GenericRepository<Category>().DeleteById(id);
            _unitOfWork.Save();
        }

        public void DeleteCategoryStatus(int id)
        {
            var model= GetByCategoryId(id);
            var Category=_mapper.Map<Category>(model);
            Category.DeleteAt = DateTime.Now;
            _unitOfWork.GenericRepository<Category>().Update(Category);
            _unitOfWork.Save();
        }

        public PagedResult<CategoryDTO> GetAllCategory(int pageNumber, int pageSize, Func<IQueryable<Category>, IQueryable<Category>> filterFull = null, Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<CategoryDTO> vmList = new List<CategoryDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Category>().GetAll(filterFull,filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Category>().GetAll(filterFull,filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }
            return new PagedResult<CategoryDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public CategoryDTO GetByCategoryId(int id)
        {
            return _mapper.Map<CategoryDTO>(_unitOfWork.GenericRepository<Category>().GetById(id));
        }

        public IEnumerable<CategoryDTO> GetCategory(Func<IQueryable<Category>, IQueryable<Category>> filterFull = null, Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Category>)_unitOfWork.GenericRepository<Category>().GetAll(filterFull,filter, orderBy,includeProperties));
        }

        public void InsertCategory(CategoryDTO Category)
        {
            var model = _mapper.Map<Category>(Category);
           
            _unitOfWork.GenericRepository<Category>().Insert(model);
            _unitOfWork.Save();
        }

        public void UpdateCategory(CategoryDTO Category)
        {
            var model=_mapper.Map<Category>(Category);
            _unitOfWork.GenericRepository<Category>().Update(model);
            _unitOfWork.Save();
        }
        private List<CategoryDTO> ConvertModelToModelViewList(List<Category> list)
        {
            return list.Select(x=>_mapper.Map<CategoryDTO>(x)).ToList();
        }
    }
}
