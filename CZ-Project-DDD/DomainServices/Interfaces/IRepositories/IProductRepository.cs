using CZ.Domain.Entities;
using System.Collections.Generic;

namespace CZ.Domain.Interfaces
{
    public interface IProductRepository: IRepositoryBase<Product>
    {
        IEnumerable<Product> GetProductByName(string Name);
    }
}
