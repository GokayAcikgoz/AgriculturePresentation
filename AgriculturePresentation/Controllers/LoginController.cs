using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
