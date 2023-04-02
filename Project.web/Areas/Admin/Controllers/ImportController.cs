using Microsoft.AspNetCore.Mvc;
using Project.Data.Entities;
using Project.Service.implement;
using Project.Service.Interface;
using Project.ViewModel;

namespace Project.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class ImportController : Controller
    {
        private readonly IImportService _importService;
        
        public ImportController(IImportService importService)
        {
            _importService = importService;
        }

        public IActionResult Index() 
        {
            var list = _importService.GetImport();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ImportDTO model)
        {
            try
            {
                _importService.InsertImport(model);
                 var c= _importService.InsertImport(model);
                
                return RedirectToAction("Create", "Import");
            }
            catch (Exception ex)
            {
                var error = "da  co loi xay ra" + ex.Message;
                return View();
            }
            return View();
        }
        public IActionResult DetailImport()
        {
            var list = _importService.GetImport();
            return View(list);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(ImportProductDTO model)
        {
            try
            {
                
                _importService.InsertImport(model);

                return RedirectToAction("Create", "Import");
            }
            catch (Exception ex)
            {
                var error = "da  co loi xay ra" + ex.Message;
                return View();
            }
            return View();
        }
    }
}
