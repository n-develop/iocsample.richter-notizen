using RichterNotizen.IocSample.Data;
using System.Collections.Generic;
using System.Linq;

namespace RichterNotizen.IocSample.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductInfo> GetTopSeller()
        {
            var products = _productRepository.GetAllProducts();
            var productInfos = products.Select(product => new ProductInfo { Name = product.Sku + " - " + product.Name, Price = product.Price }).ToList();
            return productInfos;
        }
    }
}