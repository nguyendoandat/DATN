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
    public interface IImportService
    {
        IEnumerable<ImportDTO> GetImport(Func<IQueryable<Import>, IQueryable<Import>> filterFull = null, Expression<Func<Import, bool>> filter = null, Func<IQueryable<Import>, IOrderedQueryable<Import>> orderBy = null, string includeProperties = "");
        ImportDTO GetByImportId(int id);
        IEnumerable<ImportProductDTO> GetImportProduct(Func<IQueryable<ImportProduct>, IQueryable<ImportProduct>> filterFull = null, Expression<Func<ImportProduct, bool>> filter = null, Func<IQueryable<ImportProduct>, IOrderedQueryable<ImportProduct>> orderBy = null, string includeProperties = "");
        int InsertImport(ImportDTO import);
        void InsertImport(ImportProductDTO importProduct);
        void DeleteImport(ImportProductDTO importProduct);
    }
}
