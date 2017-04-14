using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CZ.Domain.Services
{
    public class ClientService: ServiceBase<Client>, IDomainClientService
    {
      

        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository, IUnitOfWork uow) :base(uow)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return _clientRepository.GetSpecialClients(clients);
        }

       

        
    }
}
