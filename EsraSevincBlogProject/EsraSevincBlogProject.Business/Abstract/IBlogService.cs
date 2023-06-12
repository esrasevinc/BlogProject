
using EsraSevincBlogProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        int Insert(Blog p1);
        int Update(Blog p1);
        int Delete(Blog p1);
        Blog GetById(int id);
    }
}
