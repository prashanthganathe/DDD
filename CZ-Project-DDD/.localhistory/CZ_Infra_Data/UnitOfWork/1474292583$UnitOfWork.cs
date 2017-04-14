using CZ.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZ.Domain.Interfaces;
using CZ.Infra.Data.Context;
using CZ.Infra.Data.Repositories;
using System.Data.Entity.Infrastructure;

namespace CZ.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DomainContext _context;

        //public IClientRepository ClientRepo { get; private set; }
        //public IProductRepository ProductRepo { get; private set; }

        private Dictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork(DomainContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
            _disposed = false;

        }


        public IRepositoryBase<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.Keys.Contains(typeof(TEntity)))
                return _repositories[typeof(TEntity)] as IRepositoryBase<TEntity>;

            var repository = new IRepositoryBase<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }


        public int Commit()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.First().Reload();
                return -1;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
