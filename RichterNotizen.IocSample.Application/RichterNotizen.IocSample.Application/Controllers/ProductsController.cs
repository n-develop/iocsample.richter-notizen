using RichterNotizen.IocSample.Business;
using System.Web.Mvc;

namespace RichterNotizen.IocSample.Application.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Products
        public ActionResult TopSeller()
        {
            var topSeller = _productService.GetTopSeller();
            return View(topSeller);
        }
    }
}