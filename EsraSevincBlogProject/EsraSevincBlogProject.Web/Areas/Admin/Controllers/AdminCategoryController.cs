using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Areas.Admin.Controllers
{
	public class AdminCategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
