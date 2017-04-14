﻿using CZ.Domain.Entities;
using CZ.Domain.Services;
using CZ_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CZ_Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _cientService;
        public ClientAppService(ClientService clientService):base(clientService)
        {
            _cientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClients()
        {
            //Expression<Func<Client, bool>> predicate = null;
                       
            //return _cientService.GetSpecialClients(_cientService.GetAll(predicate));



            using (var uow = new UnitOfWork<CompanyContext>())
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
 