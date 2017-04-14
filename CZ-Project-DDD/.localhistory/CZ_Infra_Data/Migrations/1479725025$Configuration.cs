namespace CZ.Infra.Data.Migrations
{
    using Context;
    using seedData;
    using Domain.Entities;
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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CZ.Infra.Data.Context.DomainContext context)
        {
           var addAdmin= new AdminSeed().AdminSeedData(context);

           
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "DCPAdmin" });
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "Expert" });
                roleManager.Create(new IdentityRole { Name = "Front_Desk" });
                roleManager.Create(new IdentityRole { Name = "Site_Admin" });
                roleManager.Create(new IdentityRole { Name = "DCPMonitor" });
                roleManager.Create(new IdentityRole { Name = "RC_Site_Admin" });
                roleManager.Create(new IdentityRole { Name = "Web_Grader1" });
                roleManager.Create(new IdentityRole { Name = "Web_Grader2" });
                roleManager.Create(new IdentityRole { Name = "Web_Grader3" });
                roleManager.Create(new IdentityRole { Name = "Web_Expert" });
                roleManager.Create(new IdentityRole { Name = "GraderLevel1" });
                roleManager.Create(new IdentityRole { Name = "GraderLevel2" });
                roleManager.Create(new IdentityRole { Name = "GraderLevel3" });
                roleManager.Create(new IdentityRole { Name = "RC_Account_Admin" });
                roleManager.Create(new IdentityRole { Name = "AC_Site_Admin" });
                roleManager.Create(new IdentityRole { Name = "RC_Account_Admin" });
                roleManager.Create(new IdentityRole { Name = "AC_Account_Admin" });
                roleManager.Create(new IdentityRole { Name = "AC_Uploader" });
                roleManager.Create(new IdentityRole { Name = "Mass_Uploader" });
                roleManager.Create(new IdentityRole { Name = "Patient" });
                roleManager.Create(new IdentityRole { Name = "Prospect" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByName("admin");
            context.Clients.AddOrUpdate(p => p.FirstName, new Client { FirstName = "firstname", LastName="sd", Email = "first@gmail.com" });
            context.Clients.AddOrUpdate(p => p.FirstName, new Client { FirstName = "second", LastName="de", Email = "second@gmail.com" });

        }
    }
}
