using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Entities.Constants
{
    public class BaseEntity 
    {
        public int ID { get; set; }

        public string? CreateTime { get; set; } = DateTime.Now.ToLongDateString();
        public string? UpdateTime { get; set; } = DateTime.Now.ToLongDateString();
        public string? DeleteTime { get; set; } = DateTime.Now.ToLongDateString();
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public string? NewFileName { get; set; }
    }
}
