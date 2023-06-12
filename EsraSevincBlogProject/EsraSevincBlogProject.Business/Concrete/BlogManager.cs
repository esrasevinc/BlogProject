using EsraSevincBlogProject.Business.Abstract;
using EsraSevincBlogProject.DataAccess.Abstract;
using EsraSevincBlogProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlogProject.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public int Delete(Blog p1)
        {
            int result = _blogDal.Delete(p1);
            return result;
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetList();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public int Insert(Blog p1)
        {
            int result = _blogDal.Insert(p1);
            return result;
        }

        public int Update(Blog p1)
        {
            int result = _blogDal.Update(p1);
            return result;
        }
    }
}
