using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            List<Blog> liste = _blogService.GetAll();
            return View(liste);
        }

        public IActionResult Delete(int id)
        {
            Blog detail = _blogService.GetById(id);
            detail.DeleteTime = DateTime.Now.ToLongDateString();
            int result = _blogService.Delete(detail);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Blog detail = _blogService.GetById(id);
            detail.UpdateTime = DateTime.Now.ToLongDateString();
            return View(detail);
        }

        [HttpPost]
        public IActionResult Update(Blog p1)
        {
            p1.UpdateTime = DateTime.Now.ToLongDateString();
            int result = _blogService.Update(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Blog p1)
        {
            p1.CreateTime = DateTime.Now.ToLongDateString();
            int result = _blogService.Insert(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }
    }
}
