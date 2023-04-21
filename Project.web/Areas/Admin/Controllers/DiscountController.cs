using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service;
using Project.Service.implement;
using Project.Service.Interface;
using Project.ViewModel;
using System.Data;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
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
                var DiscountByDiscountName = _discountService.GetDiscount(null, p => p.Name == model.Name);
                if (DiscountByDiscountName.Count() != 0)
                {
                    ViewData["DiscountName"] = "Name đã tồn tại";

                }
                _discountService.InsertDiscount(model);
                return RedirectToAction("Index", "Discount");
            }
            catch(Exception ex)
            {
                var error = "Error" + ex.Message;
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            var discount = _discountService.GetByDiscountId(id);
            return View(discount);
        }
        [HttpPost]
        public IActionResult Edit(DiscountDTO discount)
        {
            try
            {
                var DiscountByDiscountName = _discountService.GetDiscount(null, p => p.Name == discount.Name && p.Id != discount.Id);
                if (DiscountByDiscountName.Count() != 0)
                {
                    ViewData["DiscountName"] = "Name đã tồn tại";

                }
                var updateDiscount = _discountService.GetByDiscountId(discount.Id);
                updateDiscount.Name = discount.Name;
                updateDiscount.StartDate = discount.StartDate;
                updateDiscount.EndDate = discount.EndDate;
                updateDiscount.DiscountPrice = discount.DiscountPrice;
                _discountService.UpdateDiscount(updateDiscount);
                return RedirectToAction("Index", "Discount");
            }
            catch (Exception ex)
            {
                var error = "da  co loi xay ra" + ex.Message;
                return View();
            }
        }
    }
}
