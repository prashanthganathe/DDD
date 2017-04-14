using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Services
{
    public class ClientService: ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository):base(clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        { 
            return clients.Where(c => c.SpecialClient(c));
        }
    }
}
