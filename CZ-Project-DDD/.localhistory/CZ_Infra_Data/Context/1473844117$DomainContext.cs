
using CZ.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CZ.Infra.Data.Context
{
    public class DomainContext : DbContext
    {
        public DomainContext(): base( "DDDDB")
        {

        }

        public DbSet<Client> Clients { get; set; }

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
           // base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(e=>e.Entity.GetType().GetProperty("CreatedOn")!=null))
            {
                if(entry.State==EntityState.Added)
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
