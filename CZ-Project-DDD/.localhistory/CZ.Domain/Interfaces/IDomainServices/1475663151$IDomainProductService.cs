using CZ.Domain.Entities;
using CZ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Interfaces.IServices
{
    public interface IProductService:IServiceBase<Product>
    {
        IEnumerable<Product> GetProductByName(string Name);
    }
}
