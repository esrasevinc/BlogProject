using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.ViewComponents.Navbar
{
	public class Navbar : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
