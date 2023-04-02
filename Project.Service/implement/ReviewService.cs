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
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public ReviewService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            
        }

        public void AddWishList(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            if(model == null)
            {
                ReviewsDTO review = new ReviewsDTO
                {
                    UserId = userId,
                    ProductId = productId,
                    IsWishList = true
                };
                _unitOfWork.GenericRepository<Reviews>().Insert(_mapper.Map<Reviews>(review));
                _unitOfWork.Save();
            }
            else
            {
                model.IsWishList = true;
                UpDateReview(model);
            }
        }

        public void Delete(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);

            model.DeleteAt = DateTime.Now;
            UpDateReview(model);
        }

        public void DeleteReview(ReviewsDTO review)
        {
           
            _unitOfWork.GenericRepository<Reviews>().Delete(_mapper.Map<Reviews>(review));
           
            _unitOfWork.Save();
        }

        public PagedResult<ReviewsDTO> GetAllReviews(int pageNumber, int pageSize, Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "")
        {
            int totalCount;
            List<ReviewsDTO> vmList = new List<ReviewsDTO>();
            try
            {
                int ExcludeRecords = (pageNumber * pageSize) - pageSize;

                var modelList = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull, filter, orderBy, includeProperties).Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull, filter, orderBy, includeProperties).ToList().Count();
                vmList = ConvertModelToModelViewList(modelList);
            }
            catch (Exception)
            {
                throw;
            }

            return new PagedResult<ReviewsDTO>(vmList, totalCount, pageNumber, pageSize);
        }

        public IEnumerable<ReviewsDTO> GetProductViewd(int size, string userId)
        {
            var modelList = _unitOfWork.GenericRepository<Reviews>().GetAll(null, filter: p => p.UserId == userId, includeProperties: "Product").Skip(0).Take(size).ToList();
            return ConvertModelToModelViewList(modelList);
        }

        public IEnumerable<ReviewsDTO> GetReview(Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "")
        {
            return ConvertModelToModelViewList((List<Reviews>)_unitOfWork.GenericRepository<Reviews>().GetAll(filterFull, filter, orderBy, includeProperties));

        }

        public ReviewsDTO GetReviewById(string userId, int productId)
        {
            var model1 = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull: null, filter: p =>  p.UserId == userId && p.ProductId == productId,orderBy:null).FirstOrDefault();


            return _mapper.Map<ReviewsDTO>(model1);
        }

        public ReviewsDTO GetReviewById(string userId)
        {
            var model=_unitOfWork.GenericRepository<Reviews>().GetById(userId);
            return _mapper.Map<ReviewsDTO>(model);
        }

        public void InsertReview(ReviewsDTO review)
        {
            var model = _mapper.Map<Reviews>(review);
            _unitOfWork.GenericRepository<Reviews>().Insert(model);
            _unitOfWork.Save();
        }

        public bool IsWishList(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            if (model == null)
            {
                return false;
            }
            else
            {
                return model.IsWishList;
            }
        }

        public void RemoveWishList(string userId, int productId)
        {
            var model = GetReviewById(userId, productId);
            model.IsWishList = false;
            UpDateReview(model);
        }

        public void UpDateReview(ReviewsDTO review)
        {
            _unitOfWork.GenericRepository<Reviews>().Update(_mapper.Map<Reviews>(review));
            _unitOfWork.Save();
        }

        public void Viewed(string userId, int productId)
        {
            var check = _unitOfWork.GenericRepository<Reviews>().GetAll(filterFull: null, filter: p => p.ProductId == productId && p.UserId == userId).FirstOrDefault();
            if (check == null)
            {
                var model = new ReviewsDTO()
                {
                    UserId = userId,
                    ProductId = productId,
                    Viewd = true,
                    DateView = DateTime.Now
                };
                Reviews review = _mapper.Map<Reviews>(model);
                _unitOfWork.GenericRepository<Reviews>().Insert(review);
                _unitOfWork.Save();
            }
            else
            {
                check.Viewd = true;
                UpDateReview(_mapper.Map<ReviewsDTO>(check));
            }
        }
        private List<ReviewsDTO> ConvertModelToModelViewList(List<Reviews> list)
        {
            return list.Select(x => _mapper.Map<ReviewsDTO>(x)).ToList();
        }
    }
}
