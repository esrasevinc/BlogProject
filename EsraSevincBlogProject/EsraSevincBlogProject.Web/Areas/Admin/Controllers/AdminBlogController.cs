using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using EsraSevincBlogProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EsraSevincBlogProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        IBlogService _blogService;
        ICategoryService _categoryService;

        public AdminBlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            List<Blog> liste = _blogService.GetAll();
            return View(liste);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<Category> liste = _categoryService.GetAll();
            List<SelectListItem> list = liste.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.ID.ToString()
            }).ToList();
            BlogViewModel a = new BlogViewModel
            {
                CatSel = list
            };
            return View(a);
        }

        [HttpPost]
        public IActionResult Add(Blog p1)
        {
            int aa = (int)p1.CategoryID;
            Category category= _categoryService.GetById(aa);

            string catename = category.CategoryName;

            p1.CreateTime = DateTime.Now.ToLongDateString();
            p1.CategoryName = catename;
            int result = _blogService.Insert(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
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
    }
}
