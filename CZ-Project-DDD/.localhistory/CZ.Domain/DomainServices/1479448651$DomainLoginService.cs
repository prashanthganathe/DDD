using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IUnitOfWork;
using CZ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.DomainServices
{
    public class DomainLoginService : DomainServiceBase<Client>, IDomainClientService
    {


        private readonly ILoginRepository _loginRepository;

        public DomainClientService(IClientRepository clientRepository, IUnitOfWork uow) : base(uow)
        {
            _loginRepository = clientRepository;
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return _loginRepository.GetSpecialClients(clients);
        }




    }
}
