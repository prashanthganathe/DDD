using CZ.Domain.Entities;
using System.Collections.Generic;

namespace CZ.Domain.Services
{
    public interface IClientService: IServiceBase<Client>
    {

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients);
    }
}
