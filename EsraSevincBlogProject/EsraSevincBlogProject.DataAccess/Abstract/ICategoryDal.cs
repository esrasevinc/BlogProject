using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsraSevincBlog.Core.Abstract;
using EsraSevincBlogProject.Entities.Entities;


namespace EsraSevincBlogProject.DataAccess.Abstract
{
    public interface ICategoryDal : IGenericRepository<Category>
    {
    }
}
