using CZ.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CZ.Infra.Data.EntityConfig
{
    public class ProductConfiguration: EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(250);
            Property(p => p.Value).IsRequired();
            HasRequired(p => p.Client).WithMany().HasForeignKey(p => p.ClientId);
        }
    }
}
