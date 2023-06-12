using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Entities.Entities
{
    public class Blog
    {
        public int ID { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogDescription { get; set; }
		public string? BlogSummary { get; set; }
		public string? BlogAuthor { get; set; }
		public string? CreateTime { get; set; }
		public string? UpdateTime { get; set; }
		public string? DeleteTime { get; set; }
	}
}
