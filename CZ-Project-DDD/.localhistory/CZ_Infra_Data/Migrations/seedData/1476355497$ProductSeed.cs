using CZ.Domain.Entities;
using System.Collections.Generic;


namespace CZ.Infra.Data.Migrations.seedData
{
    public class ProductSeed
    {
        public List<Product> UserSeedData()
        {

            List<Product> productlist = new List<Product>();
            productlist.Add(new Client() { Id = 1, FirstName = "Jane", LastName = "Austen", IsActive = true });
            productlist.Add(new Client() { Id = 2, FirstName = "John", LastName = "Bost", IsActive = true });
            productlist.Add(new Client() { Id = 3, FirstName = "Jimmy", LastName = "Caprio", IsActive = true });
            productlist.Add(new Client() { Id = 4, FirstName = "Andrew", LastName = "Sunny", IsActive = true });
            return productlist;
        }
    }
}
