using CZ.Domain.Entities;
using CZ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces.IDomainServices
{
    public interface IDomainLoginService : IDomainServiceBase<User>
    {
        User ValidateUser(User user);
    }
}
