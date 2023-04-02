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
    public interface IReviewService
    {
        PagedResult<ReviewsDTO> GetAllReviews(int pageNumber,int pageSize, Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "");
        void RemoveWishList(string userId, int productId);
        void AddWishList(string userId, int productId);
        ReviewsDTO GetReviewById(string userId,int productId);
        ReviewsDTO GetReviewById(string userId);
        void UpDateReview(ReviewsDTO review);
        void InsertReview(ReviewsDTO review);
        IEnumerable<ReviewsDTO> GetReview(Func<IQueryable<Reviews>, IQueryable<Reviews>> filterFull = null, Expression<Func<Reviews, bool>> filter = null, Func<IQueryable<Reviews>, IOrderedQueryable<Reviews>> orderBy = null, string includeProperties = "");
        bool IsWishList(string userId, int productId);
        void Viewed(string userId, int productId);
        void Delete(string userId, int productId);
        void DeleteReview(ReviewsDTO review);
        IEnumerable<ReviewsDTO> GetProductViewd(int size, string userId);
    }
}
