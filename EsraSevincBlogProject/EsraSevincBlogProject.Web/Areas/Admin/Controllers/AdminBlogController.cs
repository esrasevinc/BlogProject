using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Areas.Admin.Controllers
{
	public class AdminBlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
