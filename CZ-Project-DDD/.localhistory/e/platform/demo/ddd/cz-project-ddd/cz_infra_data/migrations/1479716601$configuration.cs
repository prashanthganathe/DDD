namespace CZ.Infra.Data.Migrations
{
    using Domain.Entities;
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

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

              context.Clients.AddOrUpdate(
                p => p.FirstName,
                new Client { FirstName = "Andrew Peters" },
                new Client { FirstName = "Brice Lambson" },
                new Client { FirstName = "Rowan Miller" }
              );

        }
    }
}
