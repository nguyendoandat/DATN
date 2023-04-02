using Microsoft.AspNetCore.Mvc;
using Project.Service.implement;
using Project.Service.Interface;
using Project.ViewModel;
using System.Security.Claims;

namespace Project.web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IReviewService _reviewService;
        public ProductController(IProductService productService, IReviewService reviewService)
        {
            _productService = productService;
            _reviewService = reviewService;
        }
        public IActionResult Index(int id)
        {
            try
            {
                var product = _productService.GetProduct(null,x => x.Id == id, null).FirstOrDefault();
                return View(product);
            }
            catch
            {
                return NotFound();
            }
            
        }
        public IActionResult AddReview(string review,int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Json(new { result = false, mess = "Bạn Chưa Đăng nhập" });
            }
            
            try
            {
                var reviewModel = _reviewService.GetReviewById(userId, id);
                if (reviewModel == null)
                {
                    ReviewsDTO reviewDTO = new ReviewsDTO
                    {
                        UserId = userId,
                        ProductId = id,
                        CreateAt = DateTime.Now,
                        ReviewDetail=review,
                    };
                    _reviewService.InsertReview(reviewDTO);
                    return Json(new { result = "ok" });
                }
                else
                {
                    reviewModel.CreateAt = DateTime.Now;
                    reviewModel.ReviewDetail = review;
                    _reviewService.UpDateReview(reviewModel);
                    return Json(new { result = "oke" });
                }

                
            }
            catch
            {
                return Json(new { result = false, mess = "Lỗi!" });
            }

        }
    }
}
