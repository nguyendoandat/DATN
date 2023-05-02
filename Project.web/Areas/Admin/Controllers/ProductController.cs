using Microsoft.AspNetCore.Mvc;
using Project.Service.implement;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;
using Project.Service.File;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Project.Data.Entities;
using System.Linq.Expressions;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService; 
        private readonly int pageSize;
        private readonly IFileService _fileService;
        public ProductController(IProductService productService, IFileService fileService, int pageSize = 5)
        {
            _productService = productService;
            _fileService = fileService;
            this.pageSize = pageSize;
        }
        public async Task<IActionResult> Index(int pageNumber, string searchString)
        {
            PagedResult<ProductDTO> list = new PagedResult<ProductDTO>();
            Expression<Func<Product, bool>> filter = null;
            ViewBag.SearchString = searchString;
            Expression<Func<Product, bool>> filterName = x => x.ProductName.Contains("");
            if (!String.IsNullOrEmpty(searchString))
            {

                filterName = x => x.ProductName.Contains(searchString);
            }
            list = _productService.GetAllProduct(pageNumber, pageSize,null, filter: filterName, null, "Category");
            return View(list);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDTO model)
        {
            try
            {
                var productByShopName = _productService.GetProduct(null,p => p.ProductName == model.ProductName);
                if (productByShopName.Count() != 0)
                {
                    ViewData["ProductName"] = "ProductName đã tồn tại";

                }
                model.Slug = model.ProductName;

                var shopBySlug = _productService.GetProduct(null,p => p.Slug == model.Slug);
                if (shopBySlug.Count() != 0)
                {
                    ViewData["Slug"] = "Slug đã tồn tại, vui lòng chọn ShopName khác";

                }
                _productService.InsertProduct(model);

                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {
                var error = "Da co loi xay ra " + ex.Message;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _productService.GetProductById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ProductDTO model)
        {
            try
            {
                var productByShopName = _productService.GetProduct(null,p => p.ProductName == model.ProductName && p.Id != model.Id);
                if (productByShopName.Count() != 0)
                {
                    ViewData["ProductName"] = "ProductName da ton tai";
                }
                model.Slug = model.ProductName;
                var shopBySlug = _productService.GetProduct(null,p => p.Slug == model.Slug && p.Id != model.Id);
                if (shopBySlug.Count() != 0)
                {
                    ViewData["Slug"] = "Slug da ton tai";
                }
                var update = _productService.GetProductById(model.Id);
                update.ProductName = model.ProductName;
                update.Slug = model.Slug;
                update.ProductDetail = model.ProductDetail;
                //update.Trend = model.Trend;
                update.Price = model.Price;
                update.UpdateAt = DateTime.Now;
                _productService.UpdateProduct(update);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var error = "da co loi xay ra" + ex.Message;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(int id )
        {
            try
            {
                _productService.DeleteProductById(id);
                return Json(new { result = true });
            }
            catch
            {
                return Json(new { result = false });
            }
        }
    }
}
