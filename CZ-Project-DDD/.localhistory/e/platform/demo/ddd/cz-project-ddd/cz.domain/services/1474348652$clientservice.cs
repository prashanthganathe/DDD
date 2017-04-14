using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZ.Infra.Data.UnitOfWork;

namespace CZ.Domain.Services
{
    public class ClientService: ServiceBase<Client>, IClientService
    {
        //private readonly IClientRepository _clientRepository;

        //public ClientService(IClientRepository clientRepository):base(clientRepository)
        //{
        //    _clientRepository = clientRepository;
        //}

        //public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        //{ 
        //    return clients.Where(c => c.SpecialClient(c));
        //}

        internal ClientService(IUnitOfWork uow) : base(uow)
        {
        }

        public IEnumerable<Client> GetSpecialClients(IEnumerable<Client> clients)
        {
            return  Repository.GetAll(c => c.FirstName == "ads");
        }


        public void ExecuteByUOW()
        {
            using (var uow = new UnitOfWork)
            {
                var catService = new Services.CategoryService(uow);
                var custService = new Services.CustomerService(uow);

                var cat = new Model.Category { Name = catName };
                catService.Add(dep);

                custService.Add(new Model.Customer { Name = custName, Category = cat });

                uow.Save();
            }
        }
    }
}
