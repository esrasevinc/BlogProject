using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
