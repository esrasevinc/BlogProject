using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsraSevincBlog.Core.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        int Insert(T t);

        int Update(T t);

        int Delete(T t);

        List<T> GetList();

        T GetById(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> filter);


    }
}
