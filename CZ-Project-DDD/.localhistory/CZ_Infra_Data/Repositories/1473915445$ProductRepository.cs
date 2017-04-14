using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using System.Collections.Generic;


namespace CZ.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetProductByName(string Name)
        {
            return base.GetAll(p => p.Name == Name);
        }
    }
}
