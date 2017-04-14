using CZ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients);
    }
}
