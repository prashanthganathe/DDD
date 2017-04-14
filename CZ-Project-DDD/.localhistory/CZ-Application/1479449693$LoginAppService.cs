using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IDomainServices;
using CZ.Domain.Services;
using CZ_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ_Application
{
    public class LoginAppService : AppServiceBase<User>, ILoginAppService
    {
        private readonly IDomainLoginService _loginService;
        public LoginAppService(DomainLoginService clientService) : base(_loginService)
        {
            _loginService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            Expression<Func<Client, bool>> predicate = null;
            int count;
            return _cientService.GetSpecialClients(_cientService.GetAll(predicate, out count));
        }


    }
}
