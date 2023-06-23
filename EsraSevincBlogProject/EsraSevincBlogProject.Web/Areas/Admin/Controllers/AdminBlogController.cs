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
        public IActionResult Add(BlogViewModel p1, IFormFile Image)
        {

            //if (!ModelState.IsValid)
            //{
            //    List<Category> liste = _categoryService.GetAll();
            //    List<SelectListItem> list = liste.Select(x => new SelectListItem
            //    {
            //        Text = x.CategoryName,
            //        Value = x.ID.ToString()
            //    }).ToList();
            //    BlogViewModel viewModel = new BlogViewModel
            //    {
            //        CatSel = list
            //    };
            //    return View(viewModel);
            //}

            int id = (int)p1.CategoryID;
            Category category= _categoryService.GetById(id);
            string categoryName = category.CategoryName;
            p1.Blog.CategoryName = categoryName;

            string FileName = Image.FileName;
            string dateTimeNow = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + DateTime.Now.Millisecond;
            string NewFileName = p1.Blog.BlogTitle + "_" + dateTimeNow + "_" + Image.FileName;
            var filePath = "";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\BlogImages");
            if (Image.Length > 0)
            {
                filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\BlogImages", NewFileName);
                using (var stream = System.IO.File.Create(filePath))
                {
                    Image.CopyToAsync(stream);
                }
            }

            p1.Blog.FileName = Image.FileName;
            p1.Blog.FilePath = path;
            p1.Blog.NewFileName = NewFileName;

            int result = _blogService.Insert(p1.Blog);
            return result == 0 ? View(p1) : RedirectToAction("Index","AdminBlog");
        }

        public IActionResult Delete(int id)
        {
            Blog detail = _blogService.GetById(id);
            
            int result = _blogService.Delete(detail);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Blog detail = _blogService.GetById(id);
           
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

            p1.CategoryName = categoryName;
            int result = _blogService.Update(p1);
            return result == 0 ? View(p1) : RedirectToAction("Index");
        }
    }
}
