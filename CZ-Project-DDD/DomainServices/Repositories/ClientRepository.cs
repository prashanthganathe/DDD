using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Repositories
{
    public class ClientRepository: RepositoryBase<Client>,IClientRepository
    {
        public ClientRepository(DomainContext context) : base(context)
        {
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return Db.Clients;
        }
    }
}
