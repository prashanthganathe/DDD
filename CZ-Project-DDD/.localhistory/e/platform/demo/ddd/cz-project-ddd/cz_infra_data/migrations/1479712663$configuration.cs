namespace CZ.Infra.Data.Migrations
{
    using AspNetIdentity.WebApi.Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CZ.Infra.Data.Context.DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CZ.Infra.Data.Context.DomainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
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
