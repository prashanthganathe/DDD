using CZ.Domain.Entities;
using System.Collections.Generic;

namespace CZ.Domain.Services
{
    public interface IDomainClientService: IDomainServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients);
    }
}
