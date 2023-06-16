using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using EsraSevincBlogProject.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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
            BlogViewModel viewModel = new BlogViewModel
            {
                CatSel = list
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(Blog p1)
        {
            int id = (int)p1.CategoryID;
            Category category= _categoryService.GetById(id);
            string categoryName = category.CategoryName;

            p1.CreateTime = DateTime.Now.ToLongDateString();
            p1.CategoryName = categoryName;
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

        [HttpGet]
        public IActionResult Update(int id)
        {
            Blog detail = _blogService.GetById(id);
            detail.UpdateTime = DateTime.Now.ToLongDateString();
            List<Category> liste = _categoryService.GetAll();
            List<SelectListItem> list = liste.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.ID.ToString()
            }).ToList();
            BlogViewModel viewModel = new BlogViewModel
            {
                CatSel = list,
                Blog = detail
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(Blog p1)
        {
            int id = (int)p1.CategoryID;
            Category category = _categoryService.GetById(id);
            string categoryName = category.CategoryName;

            p1.UpdateTime = DateTime.Now.ToLongDateString();
            p1.CategoryName = categoryName;
            int result = _blogService.Update(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }
    }
}
