using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.ViewComponents.FooterNavbar
{
	public class FooterNavbar : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
