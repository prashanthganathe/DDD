using CZ.Domain.Entities;
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
            clientList.Add(new Client() { Id = 1, FirstName = "Jane", LastName = "Austen",IsActive = true });
        
        return clientList;
    }
}
