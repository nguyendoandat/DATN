using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
