using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IServices;
using CZ.Domain.Services;
using CZ_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CZ_Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;
        public ProductAppService(ProductService productService) : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetProductByName(string Name)
        {
            return _productService.GetProductByName(Name);
        }

      
    }
}
