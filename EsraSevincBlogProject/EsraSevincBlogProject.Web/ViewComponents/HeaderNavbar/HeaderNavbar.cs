using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.ViewComponents.HeaderNavbar
{
	public class HeaderNavbar : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
