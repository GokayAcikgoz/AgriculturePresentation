using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}

		public IActionResult Index()
		{
			var values = _adminService.GetAll();
			return View(values);
		}


        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
           
                _adminService.Insert(admin);
                return RedirectToAction("Index");
          

        }

        public IActionResult DeleteAdmin(int id)
        {
            _adminService.Delete(_adminService.GetById(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var values = _adminService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {

                _adminService.Update(admin);
                return RedirectToAction("Index");
           
        }
    }
}
