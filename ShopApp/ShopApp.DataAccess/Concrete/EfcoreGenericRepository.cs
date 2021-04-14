using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public class EfcoreGenericRepository<T, TContext> : IRepository<T>
        where T : class
        where TContext : DbContext, new()


    {
        public void Create(T Entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(Entity);
                context.SaveChanges();
            }
        }

        public void Delete(T Entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(Entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return filter == null
                     ? context.Set<T>().ToList()
                     : context.Set<T>().Where(filter).ToList() ;
            }
        }

        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(filter).SingleOrDefault();
            }
        }

        public virtual void Update(T Entity)
        {
            using (var context = new TContext())
            {
                context.Entry(Entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
