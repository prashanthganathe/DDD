namespace CZ.Infra.Data.Migrations
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
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
            // context.Clients.AddOrUpdate(p=>p.FirstName,)

         context.Clients.AddOrUpdate(x => x.Id,
                 new Client() { Id = 1,  FirstName = "Jane", LastName= "Austen", IsActive=true },
                 new Client() { Id = 2, FirstName = "Charles", LastName = "Dickens", IsActive = true },
                 new Client() { Id = 3, FirstName = "Miguel de ", LastName = "Cervantes", IsActive = true }
                 );

            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 101, ClientId = 1, Name = "Product1", Value = 20.3M },
                new Product() { Id = 102, ClientId = 1, Name = "Product1", Value = 10.3M },
                new Product() { Id = 103, ClientId = 1, Name = "Product1", Value = 30.3M },
                new Product() { Id = 104, ClientId = 1, Name = "Product1", Value = 50.3M }
                );
         
        }
    }
}
