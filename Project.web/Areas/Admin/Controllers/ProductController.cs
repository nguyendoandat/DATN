using Microsoft.AspNetCore.Mvc;
using Project.Service.implement;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService; 
        private readonly int pageSize;
        public ProductController(IProductService productService, IMediasService mediasService, int pageSize = 3)
        {
            _productService = productService;
            this.pageSize = pageSize;
        }
        public async Task<IActionResult> Index(int pageNumber)
        {
            PagedResult<ProductDTO> list = new PagedResult<ProductDTO>();
            list = _productService.GetAllProduct(pageNumber, pageSize);
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDTO model)
        {
            try
            {
                var productByShopName = _productService.GetProduct(p => p.ProductName == model.ProductName);
                if (productByShopName.Count() != 0)
                {
                    ViewData["ProductName"] = "ProductName đã tồn tại";

                }
                model.Slug = model.ProductName;

                var shopBySlug = _productService.GetProduct(p => p.Slug == model.Slug);
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
                var productByShopName = _productService.GetProduct(p => p.ProductName == model.ProductName && p.Id != model.Id);
                if (productByShopName.Count() != 0)
                {
                    ViewData["ProductName"] = "ProductName da ton tai";
                }
                model.Slug = model.ProductName;
                var shopBySlug = _productService.GetProduct(p => p.Slug == model.Slug && p.Id != model.Id);
                if (shopBySlug.Count() != 0)
                {
                    ViewData["Slug"] = "Slug da ton tai";
                }
                var update = _productService.GetProductById(model.Id);
                update.ProductName = model.ProductName;
                update.Slug = model.Slug;
                update.ProductDetail = model.ProductDetail;
                update.Trend = model.Trend;
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
        public bool Delete(int id)
        {
            try
            {
                _productService.DeleteProductStatus(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
