using EsraSevincBlogProject.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EsraSevincBlogProject.Web.Areas.Admin.Models
{
    public class BlogViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<SelectListItem> CatSel { get; set; }
    }
}
