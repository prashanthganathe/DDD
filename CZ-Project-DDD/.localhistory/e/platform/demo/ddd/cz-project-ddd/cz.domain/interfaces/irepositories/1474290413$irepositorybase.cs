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
        int Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate,out int RecordCount);
        int Update(TEntity obj);
        int Remove(TEntity obj);
        void Dispose();

    }
}
