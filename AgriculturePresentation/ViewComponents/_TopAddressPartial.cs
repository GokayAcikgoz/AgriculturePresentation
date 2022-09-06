using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _TopAddressPartial:ViewComponent
	{
		private readonly IAddressService _addressService;

		public _TopAddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _addressService.GetAll();
			return View(values);
		}
	}
}
