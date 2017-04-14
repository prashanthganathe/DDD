using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CZ.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetProductByName(string Name)
        {
            return Db.Products.Where(p => p.Name == Name);
        }
    }
}
