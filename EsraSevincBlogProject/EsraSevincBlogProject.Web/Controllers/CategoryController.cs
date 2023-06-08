using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Entities.Entites;
using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            List<Category> liste = _categoryService.GetAll();
            return View(liste);
        }

        public IActionResult Delete(int id)
        {
            Category detail = _categoryService.GetById(id);
            int result = _categoryService.Delete(detail);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Category detail = _categoryService.GetById(id);
            return View(detail);
        }

        [HttpPost]
        public IActionResult Update(Category p1)
        {
            int result = _categoryService.Update(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category p1)
        {
            int result = _categoryService.Insert(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }
    }
}
