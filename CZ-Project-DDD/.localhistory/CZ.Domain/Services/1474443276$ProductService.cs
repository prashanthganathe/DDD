using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) :base(productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> GetProductByName(string Name)
        {
            return _productRepository.GetProductByName(Name);
        }
    }
}
