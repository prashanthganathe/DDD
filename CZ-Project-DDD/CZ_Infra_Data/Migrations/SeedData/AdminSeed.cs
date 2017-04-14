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
   public  class AdminSeed
    {
        public IdentityResult AdminSeedData(DomainContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "admin2",
                Email = "admin2@zeiss.com",
                EmailConfirmed = true,
                FirstName = "zeiss",
                LastName = "admin",
            };
            manager.Create(user, "Test123!");
            return manager.AddToRole(user.Id, "Admin");
        }       
    }
}
