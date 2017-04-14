using CZ.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZ.Domain.Interfaces;
using CZ.Infra.Data.Context;
using CZ.Infra.Data.Repositories;

namespace CZ.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DomainContext _context;

        public IClientRepository ClientRepo { get; private set; }
        public IProductRepository ProductRepo { get; private set; }

      

        public UnitOfWork(DomainContext context)
        {
            _context = context;
            ClientRepo = new ClientRepository(_context);
            ProductRepo = new ProductRepository(_context);
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
