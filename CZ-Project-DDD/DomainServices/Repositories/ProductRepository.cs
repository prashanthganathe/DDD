using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;
using CZ.Infra.Data.Context;

namespace CZ.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DomainContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProductByName(string Name)
        {
            return Db.Products.Where(p => p.Name == Name);
        }
    }
}
