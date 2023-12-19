using Microsoft.AspNetCore.Mvc;
using VickyFood.Repositories.Interfaces;

namespace VickyFood.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List()
        {
            var products = _productRepository.Products;
            return View(products);
        }
    }
}
