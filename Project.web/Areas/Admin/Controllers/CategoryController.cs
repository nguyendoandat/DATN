using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;
using System.Data;
using System.Linq.Expressions;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _CategoryService;
        private readonly IDiscountService _discountService;
        private readonly int pageSize;
        public CategoryController(ICategoryService CategoryService, IDiscountService discountService, int pageSize=4)
        {
            _CategoryService = CategoryService;
            _discountService = discountService;
            this.pageSize = pageSize;
        }

        public IActionResult Index(int pageNumber, string searchString)
        {
            PagedResult<CategoryDTO> list = new PagedResult<CategoryDTO>();
            Expression<Func<Category, bool>> filter = null;
            ViewBag.SearchString = searchString;
            Expression<Func<Category, bool>> filterName = x => x.CategoryName.Contains("");
            if (!String.IsNullOrEmpty(searchString))
            {

                filterName = x => x.CategoryName.Contains(searchString);
            }
            list = _CategoryService.GetAllCategory(pageNumber, pageSize, null, filter: filterName,null,"Discount");
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryDTO model)
        {
            try
            {
                var CategoryByName = _CategoryService.GetCategory(null,x => x.CategoryName == model.CategoryName);
                if (CategoryByName.Count() != 0)
                {
                    ViewData["CategoryName"] = "CategoryName da ton tai";
                    //return Json(new { result = true, isValid = false, messCategoryname = errorCategoryName });
                }
                _CategoryService.InsertCategory(model);
                return RedirectToAction("Index", "Category");
            }
            catch (Exception ex)
            {
                var error = "da  co loi xay ra" + ex.Message;
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Category = _CategoryService.GetByCategoryId(id);
            return View(Category);
        }
        [HttpPost]
        public IActionResult Edit(CategoryDTO model)
        {
            try
            {
                var CategoryByCategoryName = _CategoryService.GetCategory(null,p => p.CategoryName == model.CategoryName && p.Id != model.Id);
                if (CategoryByCategoryName.Count() != 0)
                {
                    ViewData["CategoryName"] = "CategoryName đã tồn tại";

                }
                //model.Slug = model.CategoryName;

                //var CategoryBySlug = _CategoryService.GetCategory(p => p.Slug == model.Slug && p.Id != model.Id);
                //if (CategoryBySlug.Count() != 0)
                //{
                //    ViewData["Slug"] = "Slug đã tồn tại, vui lòng chọn CategoryName khác";

                //}
                var updateCategory = _CategoryService.GetByCategoryId(model.Id);
                updateCategory.CategoryName = model.CategoryName;
                //updateCategory.Trend = model.Trend;
                updateCategory.UpdateAt = DateTime.Now;
                updateCategory.DiscountId= model.DiscountId;
                //updateCategory.Slug = model.Slug;
                _CategoryService.UpdateCategory(updateCategory);
                return RedirectToAction("Index", "Category");
            }
            catch (Exception ex)
            {
                var error = "da  co loi xay ra" + ex.Message;
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                _CategoryService.DeleteCategoryStatus(id);
                return Json(new {result=true});
            }
            catch 
            {
                return Json(new { result = false });
            }
        }
    }
}
