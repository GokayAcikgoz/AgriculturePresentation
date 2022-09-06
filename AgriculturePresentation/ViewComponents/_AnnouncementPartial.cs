using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _AnnouncementPartial : ViewComponent
	{
		private readonly IAnnouncementService _announcementService;

		public _AnnouncementPartial(IAnnouncementService announcementService)
		{
			_announcementService = announcementService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _announcementService.GetAll();
			return View();
		}
	}
}
