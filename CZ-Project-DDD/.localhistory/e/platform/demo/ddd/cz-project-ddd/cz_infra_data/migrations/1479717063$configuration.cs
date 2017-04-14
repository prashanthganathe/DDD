namespace CZ.Infra.Data.Migrations
{
    using seedData;
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using AspNetIdentity.WebApi.Infrastructure;

    internal sealed class Configuration : DbMigrationsConfiguration<CZ.Infra.Data.Context.DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CZ.Infra.Data.Context.DomainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

            //context.Clients.AddOrUpdate(
            //  p => p.Name,
            //  new Product { Name = "Andrew Peters" },
            //  new Product { Name = "Brice Lambson" },
            //  new Product { Name = "Rowan Miller" }
            //);

            //context.Clients.AddOrUpdate(p => p.FirstName, new UserSeed().UserSeedData());
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var user = new ApplicationUser()
            {
                UserName = "admin2",
                Email = "admin2@zeiss.com",
                EmailConfirmed = true,
                FirstName = "zeiss",
                LastName = "admin",
                //Level = 1,
                //JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "Test123!");

        }
    }
}
