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
       // public DomainContext Db = new DomainContext();

        protected readonly DomainContext Db;
        public RepositoryBase(DomainContext context)
        {
            Db = context;
        }

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
           // return Db.SaveChanges();
        }
        public void AddRange(IEnumerable<TEntity> entities)
        {
            Db.Set<TEntity>().AddRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Db.Set<TEntity>().SingleOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, out int count)
        {
             
            var result= Db.Set<TEntity>().Where(predicate).ToList();
            count = result.Count;
            return result;
        } 

        public TEntity GetById(int id)
        {
           return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate,  out int RecordCount)
        {
           // query = query.OrderBy(String.Format("{0} {1}", sortAndPage.SortBy, direction));

            pageindex = pageindex <= 0 ? 1 : pageindex;          
            RecordCount = Db.Set<TEntity>().Where(predicate).Count();
            return Db.Set<TEntity>().Where(predicate).Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
          //  return Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
           // return Db.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Db.Set<TEntity>().RemoveRange(entities);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
