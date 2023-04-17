using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;
        private readonly int pageSize;
        public DiscountController(IDiscountService discountService, int pageSize=8)
        {
            _discountService = discountService;
            this.pageSize = pageSize;
        }

        public IActionResult Index(int pageNumber)
        {
            
            PagedResult<DiscountDTO> list = new PagedResult<DiscountDTO>();
            list = _discountService.GetAllDiscount(pageNumber, pageSize);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiscountDTO model)
        {
            try
            {
                
                _discountService.InsertDiscount(model);
                return RedirectToAction("Index", "Discount");
            }
            catch(Exception ex)
            {
                var error = "Error" + ex.Message;
                return View();
            }
        }
    }
}
