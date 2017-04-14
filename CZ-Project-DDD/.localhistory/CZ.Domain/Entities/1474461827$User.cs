using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Passcode { get; set; }
        public string SecurityStamp { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; } = false;
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; } = false;
        public bool? TwoFactorEnabled { get; set; } = false;
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }
        public DateTime? UnlockAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public DateTime? LastLoginOn { get; set; }
        public DateTime? LastLogoutOn { get; set; }

    }
}
