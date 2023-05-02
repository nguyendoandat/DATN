using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Service.implement;
using Project.Service.Interface;
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
                startDate = DateTime.ParseExact(fromDate, "dd/MM/yyyy", null);
            }
            if (!string.IsNullOrEmpty(toDate))
            {
                endDate = DateTime.ParseExact(toDate, "dd/MM/yyyy", null);
            }

            var result = _myService.GetStatistical(startDate, endDate);
            return Json(result, new System.Text.Json.JsonSerializerOptions());
            ////var query = from o in db.Orders
            ////            join od in db.OrderDetails
            ////            on o.Id equals od.OrderId
            ////            join p in db.Products
            ////            on od.ProductId equals p.Id
            ////            select new
            ////            {
            ////                CreatedDate = o.OrderDate,
            ////                Quantity = od.Quantity,
            ////                Price = od.Price,
            ////                OriginalPrice = p.Price
            ////            };
            ////var listOrderDetail = _orderDetailService.GetOrderDetail(null,null,null, "Order");
            //var listOrder = _orderService.GetOrder();
            //var listProduct = _productService.GetProduct();
            //if (!string.IsNullOrEmpty(fromDate)){
            //    DateTime startDate = DateTime.ParseExact(fromDate, "DD/MM/yyyy", null);
            //    //query = listOrderDetail.Where(x => x.Quantity >= startDate);
            //    var listOrderDetail = _orderDetailService.GetOrderDetail(null, x=>x.Order.OrderDate>=startDate, null );
            //}
            //if (!string.IsNullOrEmpty(fromDate)){
            //    DateTime endDate = DateTime.ParseExact(toDate, "DD/MM/yyyy", null);
            //    //query = query.Where(x => x.CreatedDate < endDate);
            //    var listOrderDetail = _orderDetailService.GetOrderDetail(null, x => x.Order.OrderDate <endDate, null);
            //}
            //var result1 = _orderService.GetOrder(null);
            ////var result = query.GroupBy(x => x.CreatedDate).Select(x => new
            ////{
            ////    Date = x.Key,
            ////    TotalBuy = x.Sum(y => y.Quantity * y.OriginalPrice),
            ////    TotalSell = x.Sum(y => y.Quantity * y.Price),
            ////}).Select(x => new
            ////{
            ////    Date = x.Date,
            ////    DoanhThu = x.TotalSell,
            ////    LoiNhuan = x.TotalSell - x.TotalBuy
            ////});
            //return Json(new {Data=result1}, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}
