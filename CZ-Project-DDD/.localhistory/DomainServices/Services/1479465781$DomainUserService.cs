using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IDomainServices;
using CZ.Domain.Interfaces.IRepositories;
using CZ.Domain.Interfaces.IUnitOfWork;
using CZ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.DomainServices
{


    public class DomainClientService : DomainServiceBase<User>, IDomainUserService
    {


        private readonly IUserRepository _userRepository;

        public DomainClientService(IUserRepository userRepository, IUnitOfWork uow) : base(uow)
        {
            _userRepository = userRepository;
        }

     
    }
}
