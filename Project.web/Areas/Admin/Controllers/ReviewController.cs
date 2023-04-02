using Microsoft.AspNetCore.Mvc;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly int pageSize;
        public ReviewController (IReviewService review,int pageSize = 10)
        {
            _reviewService = review;
            this.pageSize = pageSize;
        }
        public IActionResult Index(int pageNumber)
        {
            var list = _reviewService.GetAllReviews(pageNumber, pageSize, orderBy: p => p.OrderByDescending(x => x.CreateAt), includeProperties: "User,Product");
            return View(list);
        }
        public IActionResult Delete(ReviewsDTO model)
        {
            try
            {
                _reviewService.DeleteReview(model);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }
    }
}
