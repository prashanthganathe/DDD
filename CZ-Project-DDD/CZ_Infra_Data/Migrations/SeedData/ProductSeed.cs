using CZ.Domain.Entities;
using System.Collections.Generic;


namespace CZ.Infra.Data.Migrations.seedData
{
    public class ProductSeed
    {
        public List<Product> ProductSeedData()
        {

            List<Product> productlist = new List<Product>();
            productlist.Add(new Product() { Id = 101, ClientId = 1, Name = "Product1", Value = 20.3M });
            productlist.Add(new Product() { Id = 102, ClientId = 2, Name = "Product2", Value = 10.3M });
            productlist.Add(new Product() { Id = 103, ClientId = 3, Name = "Product3", Value = 30.3M });
            productlist.Add(new Product() { Id = 104, ClientId = 4, Name = "Product4", Value = 50.3M });    
            return productlist;
        }
    }
}
