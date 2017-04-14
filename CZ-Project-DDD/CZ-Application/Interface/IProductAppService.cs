using CZ.Domain.Entities;
using System.Collections.Generic;

namespace CZ_Application.Interface
{
    public interface IProductAppService:IAppServiceBase<Product>
    {
        IEnumerable<Product> GetProductByName(string Name);
    }
}
