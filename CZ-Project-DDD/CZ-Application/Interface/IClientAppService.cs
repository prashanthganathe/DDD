using CZ.Domain.Entities;
using System.Collections.Generic;

namespace CZ_Application.Interface
{
    public interface IClientAppService:IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClients();
    }
}
