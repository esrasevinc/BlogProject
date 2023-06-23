using EsraSevincBlogProject.Entities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Entities.Entities
{
    public class Blog : BaseEntity
    {
        
        public string? BlogTitle { get; set; }
        public string? BlogDescription { get; set; }
		public string? BlogSummary { get; set; }
		public string? BlogAuthor { get; set; }
		public Category? Category { get; set; }
        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }
        

    }
}
