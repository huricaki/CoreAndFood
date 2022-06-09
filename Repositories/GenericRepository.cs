using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T:class,new() //T burada bir class olmalıdır koşulu koyduk
    {
        Context c = new Context();
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T g)
        {
            c.Set<T>().Add(g);
            c.SaveChanges();
        }
        public void TDelete(T g)
        {
            c.Set<T>().Remove(g);
            c.SaveChanges();
        }
        public void TUpdate(T g)
        {
            c.Set<T>().Update(g);
            c.SaveChanges();
        }
        public T TGet(int id)
        {
          return  c.Set<T>().Find(id);
        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
        public List<T> List(Expression<Func<T, bool>> filter)//herhangi bir sütuna göre arama işlemi sağlar
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
