using CZ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ_Application.Interface
{
        public interface ILoginAppService : IAppServiceBase<User>
        {
            User ValidateLogin();
        }
    
}
