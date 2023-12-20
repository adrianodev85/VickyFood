using Microsoft.AspNetCore.Mvc;
using VickyFood.Models;
using VickyFood.ViewModels;

namespace VickyFood.Components
{
    public class CartOverview : ViewComponent
    {
        private readonly Cart _cart;
        public CartOverview(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
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
    }
}
