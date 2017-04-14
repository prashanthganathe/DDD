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
            return new List<Client>().Add(
                      new Client() { Id = 1, FirstName = "Jane", LastName = "Austen", IsActive = true },
                     new Client() { Id = 2, FirstName = "Charles", LastName = "Dickens", IsActive = true },
                     new Client() { Id = 3, FirstName = "Miguel de ", LastName = "Cervantes", IsActive = true }
                   );
        }
    }
}
