﻿using Microsoft.AspNetCore.Identity;
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
        public CartController(IProductService productService, IUserService userService,UserManager<AppUser> userManager)
        {
            _productService = productService;
            _userService = userService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
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
            var session=HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart=JsonConvert.DeserializeObject<List<CartDTO>>(session);

            }
            return Ok(currentCart);
        }
        public IActionResult AddToCart(int id)
        {
            var product=_productService.GetProductById(id);
            var session = HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart=new List<CartDTO>();
            if (session != null)
            {
                currentCart=JsonConvert.DeserializeObject<List<CartDTO>>(session);
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
                    Price = product.Price,
                    Quantity = 1,
                };
                currentCart.Add(cart);
            }

            //int quantity = 1;
            //if (currentCart.Any(x => x.ProductId == id))
            //{
            //    quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;

            //}
            //else
            //{
            //    var cart = new CartDTO()
            //    {
            //        ProductId = id,
            //        Description = product.ProductDetail,
            //        Image = product.Thumb,
            //        Name = product.ProductName,
            //        Price = product.Price,
            //        Quantity = quantity
            //    };
            //    currentCart.Add(cart);
            //}

            HttpContext.Session.SetString(CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
            
        }
        public IActionResult UpdateCart(int id,int quantity)
        {
            var session=HttpContext.Session.GetString(CartSession);
            List<CartDTO> currentCart = new List<CartDTO>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartDTO>>(session);
            }
            foreach(var item in currentCart){
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
        public IActionResult Checkout()
        {

            return View();
        }
    }
}
