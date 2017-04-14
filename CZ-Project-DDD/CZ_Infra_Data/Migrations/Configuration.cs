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
    using SeedData;

    internal sealed class Configuration : DbMigrationsConfiguration<CZ.Infra.Data.Context.DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CZ.Infra.Data.Context.DomainContext context)
        {
         
            new RoleSeed().RoleSeedData(context);
            var addAdmin = new AdminSeed().AdminSeedData(context);
            new ClientSeed().ClientSeedData(context);



        }
    }
}
