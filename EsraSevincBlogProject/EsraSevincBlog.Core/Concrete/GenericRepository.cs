using EsraSevincBlog.Core.Abstract;
using EsraSevincBlog.Core.DataAccess;
//using EsraSevincBlogProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlog.Core.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public int Insert(T t)
        {
            using var c = new DatabaseConnect();
            c.Add(t);
            return c.SaveChanges();
        }

        public int Update(T t)
        {
            using var c = new DatabaseConnect();
            c.Update(t);
            return c.SaveChanges();
        }

        public int Delete(T t)
        {
            using var c = new DatabaseConnect();
            c.Remove(t);
            return c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new DatabaseConnect();
            return c.Set<T>().DefaultIfEmpty().ToList();
        }

        public T GetById(int id)
        {
            using var c = new DatabaseConnect();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new DatabaseConnect();
            return c.Set<T>().Where(filter).ToList();
        }
    }
}