using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity:class
    {
        void Add(TEntity obj);
        TEntity GetById();
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetPage(int pageindex, int pagesize,out int RecordCount);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

    }
}
