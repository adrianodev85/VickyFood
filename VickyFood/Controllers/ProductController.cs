using Microsoft.AspNetCore.Mvc;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;
using VickyFood.ViewModels;

namespace VickyFood.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else if(_productRepository.Products.FirstOrDefault(p => p.Category.CategoryName == category) == null)
            {
                products = _productRepository.Products.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductName);
                currentCategory = "Category Not Found";
            }
            else
            {
                products = _productRepository.Products.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductName);
                currentCategory = category;
            }

            var produtListVM = new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            };

            return View(produtListVM);
        }
    }
}
