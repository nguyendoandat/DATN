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
    public class ImportService : IImportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public ImportService(IUnitOfWork unitOfWork, IMapper mapper, IProductService productService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productService = productService;
        }

        public void DeleteImport(ImportProductDTO importProduct)
        {
            var model = _unitOfWork.GenericRepository<ImportProduct>().GetById(importProduct.Id); 
            _unitOfWork.GenericRepository<ImportProduct>().Delete(model);
            _unitOfWork.Save();
        }

        public ImportDTO GetByImportId(int id)
        {
            return _mapper.Map<ImportDTO>(_unitOfWork.GenericRepository<Import>().GetById(id));

        }

        public IEnumerable<ImportDTO> GetImport(Func<IQueryable<Import>, IQueryable<Import>> filterFull = null, Expression<Func<Import, bool>> filter = null, Func<IQueryable<Import>, IOrderedQueryable<Import>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewListImport((List<Import>)_unitOfWork.GenericRepository<Import>().GetAll(filterFull,filter, orderBy, includeProperties));
        }

        public IEnumerable<ImportProductDTO> GetImportProduct(Func<IQueryable<ImportProduct>, IQueryable<ImportProduct>> filterFull = null, Expression<Func<ImportProduct, bool>> filter = null, Func<IQueryable<ImportProduct>, IOrderedQueryable<ImportProduct>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<ImportProduct>)_unitOfWork.GenericRepository<ImportProduct>().GetAll(filterFull,filter, orderBy, includeProperties));
        }

        public int InsertImport(ImportDTO import)
        {
            var model=_mapper.Map<Import>(import);
            _unitOfWork.GenericRepository<Import>().Insert(model);
            _unitOfWork.Save();
            return model.Id;
        }

        public void InsertImport(ImportProductDTO importProduct)
        {
            var model = _mapper.Map<ImportProduct>(importProduct);
            _unitOfWork.GenericRepository<ImportProduct>().Insert(model);
            _unitOfWork.Save();
        }
        private List<ImportProductDTO> ConvertModelToModelViewList(List<ImportProduct> list)
        {
            return list.Select(x => _mapper.Map<ImportProductDTO>(x)).ToList();
        } 
        private List<ImportDTO> ConvertModelToModelViewListImport(List<Import> list)
        {
            return list.Select(x => _mapper.Map<ImportDTO>(x)).ToList();
        }
    }
}
