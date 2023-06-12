using EsraSevincBlog.Core.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.DataAccess.Abstract
{
    public interface IBlogDal : IGenericRepository<Blog>
    {
    }
}
