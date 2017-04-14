using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Dispose { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        
    }
}
