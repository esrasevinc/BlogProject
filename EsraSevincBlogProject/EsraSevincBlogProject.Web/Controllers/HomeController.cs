using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Entities.Entites;
using EsraSevincBlogProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EsraSevincBlogProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		IBlogService _blogService;


		public HomeController(ILogger<HomeController> logger, IBlogService blogService)
        {
            _logger = logger;
			_blogService = blogService;

		}

        public IActionResult Index()
        {
			List<Blog> liste = _blogService.GetAll();
			return View(liste);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}