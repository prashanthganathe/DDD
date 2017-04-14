using CZ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.EntityConfig
{
    public class SiteTypeConfiguration : EntityTypeConfiguration<SiteType>
    {
        public SiteTypeConfiguration()
        {
            HasKey(c => c.Id);
            Property(c => c.Type).IsRequired().HasMaxLength(100);         

        }
    }
}
