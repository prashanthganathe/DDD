using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository IClientsRep { get; }
        IProductRepository IProductRep { get; }
        int Complete();
    }
}
