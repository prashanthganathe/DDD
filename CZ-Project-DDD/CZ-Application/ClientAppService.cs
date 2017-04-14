using CZ.Domain.Entities;
using CZ.Domain.Services;
using CZ_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace CZ_Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IDomainClientService _cientService;
        public ClientAppService(DomainClientService clientService):base(clientService)
        {
            _cientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            Expression<Func<Client, bool>> predicate = null;
            int count;
            return _cientService.GetSpecialClients(_cientService.GetAll(predicate,out count));
        }

        
    }
} 
 