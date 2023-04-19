﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service.implement;
using Project.Service.Interface;
using Project.ViewModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Project.web.Controllers
{
    public class UserRequest
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username không được để trống")]
        public string UserName { get; set; }
    }
    public class MyProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        [TempData]
        public string Message { get; set; }
        public MyProfileController(IUserService userService, UserManager<AppUser> userManager, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _userService = userService;
            _userManager = userManager;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userService.GetUserById(userId);
            var userRequest = new UserRequest
            {
                UserName = user.UserName,
                Email = user.Email,
                Id = user.Id
            };
            return View(userRequest);
        }
        public IActionResult IndexOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var list = _orderService.GetOrder(null, x => x.UserId == userId);
            return View(list);
        }

        public IActionResult Details(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var listDetail = _orderDetailService.GetOrderDetail(null, x => x.OrderId == id && x.Order.UserId==userId,null,"Product");
            return View(listDetail); 
        }
        [HttpPost]
        public async Task<IActionResult> ChangeProfile(UserRequest user)
        {
            try
            {
                var userByName = _userService.GetUser(null, p => p.UserName == user.UserName && p.Id != user.Id);
                var userByEmail = _userService.GetUser(null, p => p.Email == user.Email && p.Id != user.Id);
                if (userByName.Count() != 0 || userByEmail.Count() != 0)
                {
                    if(userByName.Count() != 0)
                    {
                        ModelState.AddModelError(string.Empty, "Tài khoản đã tồn tại");
                        return View("Index");
                    }
                    if (userByEmail.Count() != 0)
                    {
                        ModelState.AddModelError(string.Empty, "Email đã tồn tại");
                        return View("Index");
                    }
                }
                if (!ModelState.IsValid)
                {
                    return View("Index");
                }
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userUpdate=await _userManager.FindByIdAsync(userId);
                userUpdate.UserName = user.UserName;
                userUpdate.Email = user.Email;
                userUpdate.UpdateAt = DateTime.Now;
                await _userManager.UpdateAsync(userUpdate);
                Message = "Sửa thành công";
                return RedirectToAction("Index");
            }
            catch
            {
                return NotFound();
            }
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
                updateOrder.OrderDate = order.OrderDate;
                updateOrder.StatusId = order.StatusId;
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
