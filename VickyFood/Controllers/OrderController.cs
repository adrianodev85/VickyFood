using Microsoft.AspNetCore.Mvc;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;

namespace VickyFood.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Cart _cart;

        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }

       public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            int totalOrderItems = 0;
            decimal totalOrderPrice = 0.0m;

            //Get Cart Items
            List<CartItem> items = _cart.GetCartItems();
            _cart.CartItems = items;

            //Check Items in Order
            if(_cart.CartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your Cart is Empty");
            }

            //Calculate
            foreach(var item in items)
            {
                totalOrderItems += item.Amount;
                totalOrderPrice += (item.Product.Price * item.Amount);
            }

            //Add value to order
            order.TotalItemsOrder = totalOrderItems;
            order.TotalOrder = totalOrderPrice;

            //Validate Order Data
            if(ModelState.IsValid)
            {
                //Create Order
                _orderRepository.CreateOrder(order);

                //Define Customer Messages
                ViewBag.CheckoutMessageComplete = "Thank you for your order";
                ViewBag.OrderTotal = _cart.GetCartTotal();

                //Clean Cart
                _cart.CleanCart();

                //Display View
                return View("~/Views/Order/CompleteCheckout.cshtml", order);
            }

            return View(order);
        }
    }
}
