using CZ_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CZ.Domain.Services;

namespace CZ_Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
           
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public int Add(TEntity obj)
        {
           return _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _serviceBase.GetAll(predicate);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate, out int RecordCount)
        {
            return _serviceBase.GetPage(pageindex, pagesize, predicate,out RecordCount);
        }

        public int Remove(TEntity obj)
        {
            return _serviceBase.Remove(obj);
        }

        public int Update(TEntity obj)
        {
            return _serviceBase.Update(obj);
        }
    }
}
