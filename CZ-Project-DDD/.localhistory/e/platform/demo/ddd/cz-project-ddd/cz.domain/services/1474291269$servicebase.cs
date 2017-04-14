using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CZ.Domain.Interfaces;

namespace CZ.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public int Add(TEntity obj)
        {
           return _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.GetAll(predicate);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate, out int RecordCount)
        {
            throw new NotImplementedException();
        }

        public int Remove(TEntity obj)
        {
            return _repository.Remove(obj);
        }

        public int Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
