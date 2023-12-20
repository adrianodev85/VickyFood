using Microsoft.AspNetCore.Mvc;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;
using VickyFood.ViewModels;

namespace VickyFood.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly Cart _cart;

        public CartController(IProductRepository productRepository, Cart cart)
        {
            _productRepository = productRepository;
            _cart = cart;
        }

        public IActionResult Index()
        {
            var items = _cart.GetCartItems();
            _cart.CartItems = items;

            var cartVM = new CartViewModel
            {
                Cart = _cart,
                CartTotal = _cart.GetCartTotal()
            };

            return View(cartVM);
        }
        public RedirectToActionResult AddItemToCart(int productId)
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(x => x.ProductId == productId);

            if (selectedProduct != null)
            {
                _cart.AddToCart(selectedProduct);
            }

            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveItemFromCart(int productId)
        {
            var selectedProduct = _productRepository.Products.FirstOrDefault(x => x.ProductId == productId);

            if (selectedProduct != null)
            {
                _cart.RemoveFromCart(selectedProduct);
            }

            return RedirectToAction("Index");
        }
    }
}
