using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetCoders.Madrugada.MVC.Services.Interface
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T obj);

        void CreateRange(IList<T> list);

        void Update(T obj);

        void Remove(T obj);

        IList<T> GetAll();

        IList<T> Get(Expression<Func<T, bool>> filter);
    }
}