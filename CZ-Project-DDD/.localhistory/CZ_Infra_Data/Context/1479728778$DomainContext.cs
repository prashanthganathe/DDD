
using CZ.Domain.Entities;
using CZ.Infra.Data.EntityConfig;
using CZ.Infra.Data.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CZ.Infra.Data.Context
{
    public class DomainContext :  IdentityDbContext<ApplicationUser>/*, DbContext*/
    {
        public static DomainContext Create()
        {
            return new DomainContext();
        }
        public DomainContext(): base( "PlatformDDD1", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false; 
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
       // public DbSet<User> Users { get; set; }
        public DbSet<SiteType> SiteTypes { get; set; }
      //  public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                .Where(s => s.Name == s.ReflectedType.Name + "Id")
                .Configure(s => s.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
           // modelBuilder.Configurations.Add(new UserConfiguration());
             base.OnModelCreating(modelBuilder);
        }



        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("CreatedOn") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedOn").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedOn").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
