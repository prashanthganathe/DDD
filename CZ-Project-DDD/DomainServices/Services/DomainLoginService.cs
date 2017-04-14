using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IDomainServices;
using CZ.Domain.Interfaces.IRepositories;
using CZ.Domain.Interfaces.IUnitOfWork;
using CZ.Domain.Services;
using System;


namespace CZ.Domain.DomainServices
{
    public class DomainLoginService : DomainServiceBase<User>, IDomainLoginService
    {

        private readonly ILoginRepository _loginRepository;
        public DomainLoginService(ILoginRepository loginRepository, IUnitOfWork uow) : base(uow)
        {
            _loginRepository = loginRepository;
        }

        public User ValidateUser(User user)
        {           
            return _loginRepository.ValidateUser(user);// _loginRepository.ValidateUser(user);
        }
    }
}
