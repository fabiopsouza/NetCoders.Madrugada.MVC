using System.Collections.Generic;
using System.Linq.Expressions;
using NetCoders.Madrugada.MVC.Domain.Interface;
using NetCoders.Madrugada.MVC.Services.Interface;

namespace NetCoders.Madrugada.MVC.Services.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public void Create(T obj)
        {
            _repository.Create(obj);
        }

        public void CreateRange(IList<T> list)
        {
            _repository.CreateRange(list);
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IList<T> Get(Expression<System.Func<T, bool>> filter)
        {
            return _repository.Get(filter);
        }
    }
}
