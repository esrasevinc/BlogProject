using EsraSevincBlogProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        int Insert(Category p1);
        int Update(Category p1);
        int Delete(Category p1);
        Category GetById(int id);
    }
}
