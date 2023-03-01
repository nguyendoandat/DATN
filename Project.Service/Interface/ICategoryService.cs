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
    public interface ICategoryService
    {
        PagedResult<CategoryDTO> GetAllCategory(int pageNumber, int pageSize, Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = "");

        IEnumerable<CategoryDTO> GetCategory(Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = "");
        CategoryDTO GetByCategoryId(int id);
        void InsertCategory(CategoryDTO Category);
        void UpdateCategory(CategoryDTO Category);
        void DeleteCategory(CategoryDTO Category);
        void DeleteCategoryById(int id);    
        void DeleteCategoryStatus(int id);
    }
}
