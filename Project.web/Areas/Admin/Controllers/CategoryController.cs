using Microsoft.AspNetCore.Mvc;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _CategoryService;
        private readonly int pageSize;
        public CategoryController(ICategoryService CategoryService, int pageSize=4)
        {
            _CategoryService = CategoryService;
            this.pageSize = pageSize;
        }

        public IActionResult Index(int pageNumber)
        {
            PagedResult<CategoryDTO> list = new PagedResult<CategoryDTO>();
            list = _CategoryService.GetAllCategory(pageNumber, pageSize);
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
                var CategoryByName = _CategoryService.GetCategory(x => x.CategoryName == model.CategoryName);
                if (CategoryByName.Count() != 0)
                {
                    ViewData["CategoryName"] = "CategoryName da ton tai";
                    //return Json(new { result = true, isValid = false, messCategoryname = errorCategoryName });
                }
                //model.Slug = model.CategoryName;
                //var CategoryBySlug = _CategoryService.GetCategory(x => x.Slug == model.Slug);
                //if (CategoryBySlug.Count() != 0)
                //{
                //    ViewData["Slug"] = "slug da ton tai";
                //    //return Json(new { result = true, isValid = false, messSlug = errorSlug });
                //}
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
                var CategoryByCategoryName = _CategoryService.GetCategory(p => p.CategoryName == model.CategoryName && p.Id != model.Id);
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
                updateCategory.Trend = model.Trend;
                updateCategory.UpdateAt = DateTime.Now;
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
        public bool Delete(int id)
        {
            try
            {
                _CategoryService.DeleteCategoryStatus(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
