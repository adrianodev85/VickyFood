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

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else if (_productRepository.Products.FirstOrDefault(p => p.Category.CategoryName == category) == null)
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
        public IActionResult Details(int productId)
        {
            var product = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }
        public ViewResult Search(string searchstring)
        {
            IEnumerable<Product> products;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(searchstring))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
                currentCategory = "All Products";
            }
            else
            {
                products = _productRepository.Products.Where(p => p.ProductName.ToLower()
                    .Contains(searchstring.ToLower()));
                if (products.Any())
                {
                    currentCategory = "Products";
                }
                else
                {
                    currentCategory = "Product not Found";
                }
            }

            return View("/Views/Product/List.cshtml", new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
    }
}
