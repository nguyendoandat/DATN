using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;
using System.Data;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin, Shipper")]
    public class ShipperOrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IProductService _productService;
        private readonly int pageSize;
        public ShipperOrderController(IOrderService orderService, IOrderDetailService orderDetailService, IProductService productService, int pageSize=8)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _productService = productService;
            this.pageSize = pageSize;
        }

        public IActionResult Index(int pageNumber)
        {
            PagedResult<OrderDTO> list = new PagedResult<OrderDTO>();
            Func<IQueryable<Order>, IQueryable<Order>> filterFull = null;
            Expression<Func<Order, bool>> filterOrder = null;
            Func<IQueryable<Order>, IOrderedQueryable<Order>> sort = null;
            
            list = _orderService.GetAllOrder(pageNumber, pageSize, filterFull, x=>x.StatusId==3, sort, "Status");
            return View(list);
        }
        public IActionResult IndexDeliverer()
        {
           // PagedResult<OrderDTO> list = new PagedResult<OrderDTO>();
            Func<IQueryable<Order>, IQueryable<Order>> filterFull = null;
            Expression<Func<Order, bool>> filterOrder = null;
            Func<IQueryable<Order>, IOrderedQueryable<Order>> sort = null;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
           var list = _orderService.GetOrder( filterFull, x => x.StatusId == 4 && x.ShipperId==userId, sort, "Status");
            return View(list);
        }
        public IActionResult SuccessDelivery(int pageNumber)
        {
            PagedResult<OrderDTO> list = new PagedResult<OrderDTO>();
            Func<IQueryable<Order>, IQueryable<Order>> filterFull = null;
            Expression<Func<Order, bool>> filterOrder = null;
            Func<IQueryable<Order>, IOrderedQueryable<Order>> sort = null;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            list = _orderService.GetAllOrder(pageNumber, pageSize, filterFull, x => x.StatusId == 5 && x.ShipperId == userId, sort, "Status");
            return View(list);
        }
        public IActionResult Edit(int id)
        {
            var order = _orderService.GetByOrderId(id);
            return View(order);
        }
        [HttpPost]

        public IActionResult Edit(OrderDTO order)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var updateOrder = _orderService.GetByOrderId(order.Id);
                updateOrder.ShipPhoneNumber = order.ShipPhoneNumber;
                updateOrder.ShipName = order.ShipName;
                updateOrder.ShipAddress = order.ShipAddress;
                updateOrder.ShipEmail = order.ShipEmail;
                updateOrder.OrderDate = order.OrderDate;
                updateOrder.StatusId = order.StatusId;
                updateOrder.ShipperId=userId;
                updateOrder.UpdateAt = DateTime.Now;
                if (updateOrder.StatusId == 3)
                {
                    
                }
                if(updateOrder.StatusId == 5)
                {
                    updateOrder.EndAt = DateTime.Now.AddDays(2);
                }
                _orderService.UpdateOrder(updateOrder);
                return Json(new { result = true, isValid = true });
            }
            catch (Exception ex)
            {
                var error = "da  co loi xay ra" + ex.Message;
                return Json(new { result = false, message = "Đã xảy ra lỗi, vui lòng thử lại sau" });
            }

        }
    }
}
