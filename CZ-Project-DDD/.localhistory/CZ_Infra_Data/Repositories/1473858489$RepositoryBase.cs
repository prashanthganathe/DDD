using CZ.Domain.Interfaces;
using CZ.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return Db.Set<TEntity>().ToList();
        } 

        public TEntity GetById(int id)
        {
           return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate, out int RecordCount)
        {
            if (pageindex <= 0)
                pageindex = 1;
            RecordCount = Db.Set<TEntity>().Count();
            return Db.Set<TEntity>().Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }

        public int Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
