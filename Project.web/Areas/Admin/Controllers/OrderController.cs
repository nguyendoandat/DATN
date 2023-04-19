using Microsoft.AspNetCore.Mvc;
using Project.Service.implement;
using Project.Service;
using Project.Service.Interface;
using Project.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data.Entities;
using System.Linq.Expressions;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IProductService _productService;
        private readonly int pageSize;
        public OrderController(IOrderService orderService,IOrderDetailService orderDetailService, IProductService productService, int pageSize=8)
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
            list = _orderService.GetAllOrder(pageNumber, pageSize, filterFull, filterOrder, sort, "Status");
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
                var updateOrder = _orderService.GetByOrderId(order.Id);
                updateOrder.ShipPhoneNumber = order.ShipPhoneNumber;
                updateOrder.ShipName = order.ShipName;
                updateOrder.ShipAddress = order.ShipAddress;
                updateOrder.ShipEmail = order.ShipEmail;
                updateOrder.OrderDate=order.OrderDate;
                updateOrder.StatusId=order.StatusId;
                if (updateOrder.StatusId == 3)
                {
                    var listOrderDetail = _orderDetailService.GetOrderDetail(null, x => x.OrderId == order.Id);
                    var listProduct = _productService.GetProduct();
                    foreach(var item in listOrderDetail)
                    {
                        foreach(var product in listProduct)
                        {
                            if (item.ProductID == product.Id)
                            {
                                product.Quantity -= item.Quantity;
                                _productService.UpdateProduct(product);
                            }
                        }
                    }
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
