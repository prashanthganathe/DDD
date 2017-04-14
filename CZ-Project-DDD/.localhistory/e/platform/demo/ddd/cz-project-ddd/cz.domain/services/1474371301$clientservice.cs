using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CZ.Domain.Services
{
    public class ClientService: ServiceBase<Client>, IClientService
    {
        internal ClientService(IUnitOfWork uow) : base(uow)
        {
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return _unitOfWork.GetRepository<Client>().GetAll(c => c.FirstName == "aa");
           
        }


        
    }
}
