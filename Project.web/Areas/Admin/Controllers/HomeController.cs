using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Service.implement;
using Project.Service.Interface;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly MyService _myService;
        private AppDbContext db;
        public HomeController(IProductService productService, IOrderService orderService, IOrderDetailService orderDetailService,MyService myService)
        {
            _productService = productService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _myService = myService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetStatistical(string fromDate,string toDate)
        {
            DateTime? startDate = null;
            DateTime? endDate = null;

            if (!string.IsNullOrEmpty(fromDate))
            {
                startDate = DateTime.ParseExact(fromDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            if (!string.IsNullOrEmpty(toDate))
            {
                endDate = DateTime.ParseExact(toDate, "yyyy-MM-dd", null);
            }

            var result = _myService.GetStatistical(startDate, endDate);
            return Json(result, new System.Text.Json.JsonSerializerOptions());
        }
    }
}
