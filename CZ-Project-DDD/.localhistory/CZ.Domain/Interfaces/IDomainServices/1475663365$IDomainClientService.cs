using CZ.Domain.Entities;
using System.Collections.Generic;

namespace CZ.Domain.Services
{
    public interface IDomainClientService: IServiceBase<Client>
    {

        IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients);
    }
}
