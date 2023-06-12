using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Entities.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string? CategoryName { get; set; }
		public string? CreateTime { get; set; }
		public string? UpdateTime { get; set; }
		public string? DeleteTime { get; set; }

	}
}
