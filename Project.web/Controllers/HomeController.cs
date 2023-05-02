using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Data.Entities;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;
using Project.web.Models;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Project.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IReviewService _reviewService;
        

        public HomeController(ILogger<HomeController> logger, IProductService productService, IReviewService reviewService)
        {
            _logger = logger;
            _productService = productService;
            _reviewService = reviewService;
        }

        public IActionResult Index()
        {
            var list = _productService.GetProduct();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MyWishList()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var list = _reviewService.GetReview(filter: p => p.UserId == userId && p.IsWishList == true, includeProperties: "Product");
            return View(list);
        }
        public IActionResult AddWishList(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return Json(new { result = false, mess = "Bạn Chưa Đăng nhập" });
            }
            try
            {

                _reviewService.AddWishList(userId, id);
                return Json(new { result = "ok" });
            }
            catch
            {
                return Json(new { result = false, mess = "Lỗi!" });
            }
        }
        public IActionResult MyReview(int pageNumber)
        {
            int pageSize = 8;
            var list = _reviewService.GetAllReviews(pageNumber, pageSize, orderBy: p => p.OrderByDescending(x => x.CreateAt), includeProperties: "User,Product");
            return View(list);
        }
        public IActionResult GetReview(int productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var review = _reviewService.GetReviewById(userId, productId);
                return Json(new { review = review.ReviewDetail });
            }
            catch
            {
                return Json(new { review = false });
            }
        }
        public IActionResult EditReview(int productId, string review)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var model = _reviewService.GetReviewById(userId, productId);
                model.ReviewDetail = review;
                model.UpdateAt = DateTime.Now;
                _reviewService.UpDateReview(model);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }
        public IActionResult ProductHome(int pageNumber,string searchString,int? categoryId)
        {
            int pageSize = 12;
            PagedResult<ProductDTO> list = new PagedResult<ProductDTO>();
            Func<IQueryable<Product>, IQueryable<Product>> filterFull = null;
            Expression<Func<Product, bool>> filterCategory = null;
            Func<IQueryable<Product>, IOrderedQueryable<Product>> sort = null;
            if (categoryId != null)
            {
                ViewBag.CategoryId = categoryId;
                filterCategory = p => p.CategoryId == categoryId;
            }
            ViewBag.SearchString1 = searchString;
            ViewBag.Category1 = categoryId;
            Expression<Func<Product, bool>> filterName = x => x.ProductName.Contains("");
            if (!String.IsNullOrEmpty(searchString))
            {
                filterName = x => x.ProductName.Contains(searchString);
            }
            filterFull = list => list.Where(filterName);
            try
            {

                list = _productService.GetAllProduct(pageNumber, pageSize, filterFull, filter: filterCategory, orderBy: sort, "Category.Discount");

                return View(list);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        public IActionResult Product(int pageNumber, int? min, int? max, string searchString, int? categoryId)
        {
            int pageSize = 12;
            PagedResult<ProductDTO> list = new PagedResult<ProductDTO>();
            Func<IQueryable<Product>, IQueryable<Product>> filterFull = null;
            Expression<Func<Product, bool>> filterCategory = null;
            Func<IQueryable<Product>, IOrderedQueryable<Product>> sort = null;
            if (categoryId != null)
            {
                ViewBag.CategoryId = categoryId;
                filterCategory = p => p.CategoryId == categoryId;
            }
            ViewBag.SearchString = searchString;
            ViewBag.Category = categoryId;
            ViewBag.Min = min;
            ViewBag.Max = max;
            Expression<Func<Product, bool>> filterName = x => x.ProductName.Contains("");
            Expression<Func<Product, bool>> filterPrice = x => x.ProductName.Contains("");
            if (min != null && max != null && min <= max)
            {
                filterPrice = p => p.Price >= min && p.Price <= max;
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                filterName = x => x.ProductName.Contains(searchString);
            }
            filterFull = list => list.Where(filterName).Where(filterPrice);
            try
            {
                
                    list = _productService.GetAllProduct(pageNumber, pageSize, filterFull, filter: filterCategory, orderBy: sort, "Category.Discount");
                    
                return View(list);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}