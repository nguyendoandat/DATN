using AutoMapper;
using Project.Data.Entities;
using Project.Service.File;
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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _file;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper,IFileService file)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _file = file;
        }

        public void DeleteProduct(ProductDTO product)
        {
            var model = _unitOfWork.GenericRepository<Product>().GetById(product.Id);
            //var c = model.Thumb;
            _unitOfWork.GenericRepository<Product>().Delete(model);
            //_file.DeleteFile(c);
            _unitOfWork.Save();
            _file.DeleteFile(product.Thumb);
            
        }

        public void DeleteProductById(int id)
        {
            var product = GetProductById(id);
            _unitOfWork.GenericRepository<Product>().DeleteById(id);
            _unitOfWork.Save();
            _file.DeleteFile(product.Thumb);
        }

        public void DeleteProductStatus(int id)
        {
            var product = GetProductById(id);
            var model = _mapper.Map<Product>(product);
            model.DeleteAt = DateTime.Now;
            _unitOfWork.GenericRepository<Product>().Update(model);
            _unitOfWork.Save();
        }

        public PagedResult<ProductDTO> GetAllProduct(int pageNumber, int pageSize, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<ProductDTO> vmList = new List<ProductDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Product>().GetAll(filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Product>().GetAll(filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }
            return new PagedResult<ProductDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<ProductDTO> GetProduct(Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeProperties = "")
        {
           
            return ConvertModelToModelViewList((List<Product>)_unitOfWork.GenericRepository<Product>().GetAll(filter, orderBy, includeProperties));
        }

        public ProductDTO GetProductById(int id)
        {
            return _mapper.Map<ProductDTO>(_unitOfWork.GenericRepository<Product>().GetById(id));
        }

        public IEnumerable<ProductDTO> GetTopTenProduct(int size)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetTrendingProduct(int size)
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(ProductDTO product)
        {
            var model=_mapper.Map<Product>(product);
            model.Thumb = _file.UpLoadFile(product.File);
            _unitOfWork.GenericRepository<Product>().Insert(model);
            _unitOfWork.Save();
            //return model.Id;
        }

        public void UpdateProduct(ProductDTO product)
        {
            var model = _mapper.Map<Product>(product);
            _unitOfWork.GenericRepository<Product>().Update(model);
            _unitOfWork.Save();
        }
        private List<ProductDTO> ConvertModelToModelViewList(List<Product> list)
        {
            return list.Select(x => _mapper.Map<ProductDTO>(x)).ToList();
        }
    }
}
