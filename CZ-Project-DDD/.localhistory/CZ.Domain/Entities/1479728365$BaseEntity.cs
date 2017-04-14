using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Entities
{
    public abstract class BaseEntity
    {
        public DateTime? UpdatedOn { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;
    }
}
