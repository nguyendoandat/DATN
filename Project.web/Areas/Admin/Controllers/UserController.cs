using Microsoft.AspNetCore.Mvc;
using Project.Service;
using Project.Service.implement;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly int pageSize;
        public UserController(IUserService userService, int pageSize=4)
        {
            _userService = userService;
            this.pageSize = pageSize;
        }

        public IActionResult Index(int pageNumber)
        {
            PagedResult<UserDTO> list = new PagedResult<UserDTO>();

            list = _userService.GetAllUser(pageNumber, pageSize);
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserDTO user)
        {
            try
            {
                var userByName = _userService.GetUser(p => p.UserName == user.UserName);
                var userByEmail = _userService.GetUser(p => p.Email == user.Email);
                if (userByName.Count() != 0 || userByEmail.Count() != 0)
                {
                    if (userByName.Count() != 0)
                    {
                        ViewData["UserName"] = "Username da ton tai";
                    }
                    if (userByEmail.Count() != 0)
                    {
                        ViewData["Email"] = "Email da ton tai";
                    }
                }
                _userService.InsertUser(user);
                return RedirectToAction("Index", "User");
            }
            catch (Exception ex)
            {
                var error = "Da co loi xay ra " + ex.Message;
                return View();
            }
        }
        [HttpPost]
        public bool Delete(string id)
        {
            try
            {
                _userService.DeleteUserById(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
