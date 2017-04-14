using CZ.Domain.DomainServices;
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
        public LoginAppService(DomainLoginService loginService) : base(loginService)
        {
            _loginService = loginService;
        }

        public User ValidateUser(User user)
        {
            return _loginService.ValidateUser(user);
        }

    


    }
}
