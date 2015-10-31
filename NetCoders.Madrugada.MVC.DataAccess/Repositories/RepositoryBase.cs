using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using NetCoders.Madrugada.MVC.DataAccess.Context;
using NetCoders.Madrugada.MVC.Domain.Interface;

namespace NetCoders.Madrugada.MVC.DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class 
    {
        protected readonly SisTinderContext Ctx = new SisTinderContext();

        public void Create(T obj)
        {
            Ctx.Set<T>().Add(obj);
            Ctx.SaveChanges();
        }

        public void CreateRange(IList<T> list)
        {
            Ctx.Set<T>().AddRange(list);
            Ctx.SaveChanges();
        }

        public void Update(T obj)
        {
            Ctx.Entry(obj).State = EntityState.Modified;
            Ctx.SaveChanges();
        }

        public void Remove(T obj)
        {
            Ctx.Set<T>().Remove(obj);
            Ctx.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return Ctx.Set<T>().ToList();
        }

        public IList<T> Get(Expression<Func<T, bool>> filter)
        {
            return Ctx.Set<T>().Where(filter).ToList();
        }
    }
}
