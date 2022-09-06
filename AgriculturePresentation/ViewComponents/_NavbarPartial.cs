using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _NavbarPartial : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{ 
			return View(); 
		}
	}
}
