namespace CZ.Infra.Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CZ.Infra.Data.Migrations.seedData;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CZ.Infra.Data.Context.DomainContext context)
        {         

            context.Clients.AddOrUpdate(x => x.Id, new UserSeed().UserSeedData().ToArray());
            context.Products.AddOrUpdate(x => x.Id, new ProductSeed().ProductSeedData().ToArray());
            context.Roles.AddOrUpdate(x => x.Id, new RoleSeed().RoleSeedData().ToArray());


        }
    }
}
