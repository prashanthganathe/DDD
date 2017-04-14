using AspNetIdentity.WebApi.Infrastructure;
using CZ.Domain.Entities;
using CZ.Infra.Data.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Migrations.seedData
{
   public  class UserSeed
    {
        public List<Client> UserSeedData()
        {

            List<Client> clientList = new List<Client>();
            clientList.Add(new Client() { Id = 1, FirstName = "Jane", LastName = "Austen", IsActive = true });
            clientList.Add(new Client() { Id = 2, FirstName = "John", LastName = "Bost", IsActive = true });
            clientList.Add(new Client() { Id = 3, FirstName = "Jimmy", LastName = "Caprio", IsActive = true });
            clientList.Add(new Client() { Id = 4, FirstName = "Andrew", LastName = "Sunny", IsActive = true });
            return clientList;
        }

       
    }
}
