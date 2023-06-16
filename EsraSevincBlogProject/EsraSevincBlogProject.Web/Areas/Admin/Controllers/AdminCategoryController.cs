using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EsraSevincBlogProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController : Controller
	{
        ICategoryService _categoryService;

        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
		{
            List<Category> liste = _categoryService.GetAll();
            return View(liste);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category p1)
        {
            p1.CreateTime = DateTime.Now.ToLongDateString();
            int result = _categoryService.Insert(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            Category detail = _categoryService.GetById(id);
            detail.DeleteTime = DateTime.Now.ToLongDateString();
            int result = _categoryService.Delete(detail);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Category detail = _categoryService.GetById(id);
            detail.UpdateTime = DateTime.Now.ToLongDateString();
            return View(detail);
        }

        [HttpPost]
        public IActionResult Update(Category p1)
        {
            p1.UpdateTime = DateTime.Now.ToLongDateString();
            int result = _categoryService.Update(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }
    }
}
