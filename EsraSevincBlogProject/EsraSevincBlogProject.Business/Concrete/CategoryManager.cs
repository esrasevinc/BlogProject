using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.DataAccess.Abstract;
using EsraSevincBlogProject.Entities.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int Delete(Category p1)
        {
            int result = _categoryDal.Delete(p1);
            return result;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public int Insert(Category p1)
        {
            int result = _categoryDal.Insert(p1);
            return result;
        }

        public int Update(Category p1)
        {
            int result = _categoryDal.Update(p1);
            return result;
        }

    }
}
