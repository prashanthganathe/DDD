using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IUnitOfWork;

namespace CZ.Domain.Services
{
    public abstract class DomainServiceBase<TEntity> : IDisposable, IDomainServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        protected IRepositoryBase<TEntity> Repository
        {
            get { return _repository; }
        }

        protected readonly IUnitOfWork _unitOfWork;
        internal ServiceBase(IUnitOfWork uow)
        {
            this._unitOfWork = uow;
            _repository = uow.GetRepository<TEntity>();
        }



        public void Dispose()
        {
            _repository.Dispose();
        }

        public int Add(TEntity obj)
        {
            // _unitOfWork.GetRepository<TEntity>().Add(obj);
            //  return _unitOfWork.Commit();
            _repository.Add(obj);
            return _unitOfWork.Commit();
        }



        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            // return _repository.GetAll(predicate);
            return _repository.GetAll(predicate);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetPage(int pageindex, int pagesize, Expression<Func<TEntity, bool>> predicate, out int RecordCount)
        {
            return _repository.GetPage(pageindex, pagesize, predicate, out RecordCount);
        }

        public int Remove(TEntity obj)
        {
            _repository.Remove(obj);
            return _unitOfWork.Commit();
        }

        public int Update(TEntity obj)
        {
            _repository.Update(obj);
            return _unitOfWork.Commit();
        }
    }
}
