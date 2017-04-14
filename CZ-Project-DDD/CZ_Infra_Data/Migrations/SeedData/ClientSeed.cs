using CZ.Domain.Entities;
using CZ.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Migrations.SeedData
{
    public class ClientSeed
    {
        public void ClientSeedData(DomainContext context)
        {
            context.Clients.AddOrUpdate(p => p.FirstName, new Client { FirstName = "firstname", LastName = "sd", Email = "first@gmail.com" });
            context.Clients.AddOrUpdate(p => p.FirstName, new Client { FirstName = "second", LastName = "de", Email = "second@gmail.com" });
        }
    }

}