using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Data.Entities;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        public const string CartSession = "CartSession";
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        
        public CartController(IProductService productService, IUserService userService, UserManager<AppUser> userManager
            , IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _productService = productService;
            _userService = userService;
            _userManager = userManager;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            if (HttpContext.Session.GetString(CartSession) == null)
            {
                return Redirect("/gio-hang.html");
            }
            return View();
        }
        public IActionResult CreateOrder(string model)
            {
            try
            {
                var order = JsonConvert.DeserializeObject<OrderDTO>(model);

                if (User.Identity.IsAuthenticated)
                {
                    order.UserId = _userManager.GetUserId(HttpContext.User);
                }
              
                var session = HttpContext.Session.GetString(CartSession);
                List<CartDTO> currentCart = new List<CartDTO>();
                if (session != null)
                {
                    currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
                }
                var c = _orderService.Create(order);
                var orderDetails = new OrderDetailDTO();
                var listProduct = _productService.GetProduct();
                foreach (var item in currentCart)
                {
                    orderDetails.OrderID = c;
                    orderDetails.ProductID = item.ProductId;
                    orderDetails.Quantity = item.Quantity;
                    orderDetails.Price = item.Price;
                    foreach (var product in listProduct)
                    {
                        if (item.ProductId == product.Id)
                        {
                            product.Quantity -= item.Quantity;
                            _productService.UpdateProduct(product);
                        }
                    }
                    _orderDetailService.Create(orderDetails);

                }

                return Json(new
                {
                    status = true
                });
            }
            catch
            {
                return Json(new
                {
                    status = false
                });
            }

        }

        public IActionResult GetUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                var user = _userService.GetUserById(userId);
                return Json(new
                {
                    data = user,
                    status = true
                });
            }
            return Json(new
            {
                status = false
            });
        }

        [HttpGet]
        public IActionResult GetListItem()
        {
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);

            }
            return Ok(currentCart);
        }
        public IActionResult AddToCart(int id,int quantity)
        {
            var product = _productService.GetProductById(id);
            var productByCategory=_productService.GetProduct(null,x=>x.Id==id,null,includeProperties: "Category.Discount");
            if(product.Quantity < quantity)
            {
                ViewBag.Error = "Số lượng sản phẩm không đủ";
                return NotFound();
            }
            else
            {
                foreach (var item in productByCategory)
                {
                    double a = decimal.ToDouble(item.Price) - decimal.ToDouble(item.Price)*(item.Category.Discount.DiscountPrice/100);
                    var session = HttpContext.Session.GetString(CartSession);
                    List<CartDTO> currentCart = new List<CartDTO>();
                    if (session != null)
                    {
                        currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
                    }
                    var cartitem = currentCart.Find(x => x.ProductId == id);
                    if (cartitem != null)
                    {
                        cartitem.Quantity++;
                    }

                    else
                    {
                        var cart = new CartDTO()
                        {
                            ProductId = id,
                            Description = product.ProductDetail,
                            Image = product.Thumb,
                            Name = product.ProductName,
                            Price = (decimal)a,
                            Quantity = quantity,
                        };
                        currentCart.Add(cart);
                    }
                    HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(currentCart));
                    return Ok(currentCart);
                }
                return Ok();
            }
            

            //return Ok();

        }
        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
            }
            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }
            HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }
        public IActionResult DeleteAll()
        {
            //Session[CartSession] = new List<CartDTO>();
            var session = HttpContext.Session;
            session.Remove(CartSession);
            return Json(new
            {
                status = true
            });
        }

    }
}
