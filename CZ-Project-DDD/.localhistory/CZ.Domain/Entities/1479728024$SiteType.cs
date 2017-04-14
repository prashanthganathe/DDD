using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Entities
{
    public class SiteType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual IEnumerable<Role> Roles { get; set; }
    }
}
