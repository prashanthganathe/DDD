using CZ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces.IRepositories
{


    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetSpecialClients(User user);
    }
}
