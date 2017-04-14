using CZ.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CZ.Infra.Data.EntityConfig
{
    public class UserConfig: EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.UserName).IsRequired().HasMaxLength(50);
            Property(c => c.PasswordHash).IsRequired().HasMaxLength(400);
            Property(c => c.Passcode).IsRequired().HasMaxLength(6);
            Property(c => c.SecurityStamp).IsRequired().HasMaxLength(400);
            Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            Property(c => c.MiddleName).HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);

            Property(c => c.Email).IsRequired();
        }
    }
}
