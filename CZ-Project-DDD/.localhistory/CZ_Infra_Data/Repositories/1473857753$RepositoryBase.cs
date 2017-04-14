using CZ.Domain.Interfaces;
using CZ.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace CZ.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DomainContext Db = new DomainContext();
        public int Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetPage(int pageindex, int pagesize, out int RecordCount)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
