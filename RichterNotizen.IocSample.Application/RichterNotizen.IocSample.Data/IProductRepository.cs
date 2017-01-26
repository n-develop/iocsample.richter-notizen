using System.Collections.Generic;

namespace RichterNotizen.IocSample.Data
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
