using System.Collections.Generic;
using System.Linq;

namespace RichterNotizen.IocSample.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Product GetProductById(int id)
        {
            return _databaseContext.Products.Find(id);
        }

        public List<Product> GetAllProducts()
        {
            return _databaseContext.Products.ToList();
        }
    }
}