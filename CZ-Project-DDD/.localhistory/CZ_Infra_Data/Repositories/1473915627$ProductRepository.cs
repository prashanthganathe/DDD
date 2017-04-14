using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using System.Collections.Generic;
using System;

namespace CZ.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetProductByName(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
