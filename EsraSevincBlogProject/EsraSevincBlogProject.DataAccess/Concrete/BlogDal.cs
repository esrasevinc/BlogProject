using EsraSevincBlog.Core.Concrete;
using EsraSevincBlogProject.DataAccess.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.DataAccess.Concrete
{
    public class BlogDal : GenericRepository<Blog>, IBlogDal
    {
    }
}
