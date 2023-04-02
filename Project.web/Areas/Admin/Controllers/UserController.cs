using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service;
using Project.Service.implement;
using Project.Service.Interface;
using Project.ViewModel;
using System.Security.Claims;
using System.Text;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly int pageSize;
        private readonly UserManager<AppUser> _userManager;
        public UserController(IUserService userService, UserManager<AppUser> userManager, int pageSize = 4)
        {
            _userService = userService;
   
            _userManager = userManager;
            this.pageSize = pageSize;
            
        }

        public async Task<IActionResult> Index1()
        {
            PagedResult<UserDTO> list = new PagedResult<UserDTO>();
            List<IdentityRole> roles = new List<IdentityRole>();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var role = _userManager.GetRolesAsync(userId);
            var rolename =await _userManager.GetUsersInRoleAsync("User");

            return View(rolename.ToList());
            //if (rolename != null)
            //{ 
            //    list = _userService.GetAllUser(pageNumber, pageSize/*,null, p => p.Id != userId*/);
                
            //}
            //return View(list);

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
        public async Task<IActionResult> Create(UserDTO user)
        {
            try
            {
                var userByName = _userService.GetUser(null,p => p.UserName == user.UserName);
                var userByEmail = _userService.GetUser(null,p => p.Email == user.Email);
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
                var appUser = new AppUser { UserName = user.UserName, Email = user.Email, CreateAt = DateTime.Now };

                var result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);
                    await _userManager.AddToRoleAsync(currentUser, user.Role);
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
