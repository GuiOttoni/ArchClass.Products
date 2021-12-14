using ArchClass.Products.Contract;
using System.Collections.Generic;

namespace ArchClass.Products.Service.Interface
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProductByStoreName(string storeName);
    }
}
