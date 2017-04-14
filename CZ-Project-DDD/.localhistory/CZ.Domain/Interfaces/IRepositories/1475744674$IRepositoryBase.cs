using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity:class
    {
        void Add(TEntity obj);
        void AddRange(IEnumerable<TEntity> entities);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate,out int RecordCount);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Dispose();

    }
}
