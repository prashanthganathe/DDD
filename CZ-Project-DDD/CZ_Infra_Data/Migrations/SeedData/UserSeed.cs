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

namespace CZ.Infra.Data.Migrations.SeedData
{
    public class UserSeed
    {
        public IdentityResult UserSeedData(DomainContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "user1",
                Email = "user1@zeiss.com",
                EmailConfirmed = true,
                FirstName = "user",
                LastName = "user1",
            };
            manager.Create(user, "Test123!");
            return manager.AddToRole(user.Id, "User");

        }
    }
}
