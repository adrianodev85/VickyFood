using VickyFood.Infrastructure;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;

namespace VickyFood.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        private readonly Cart _cart;

        public OrderRepository(AppDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderDispatched = DateTime.Now;

            _context.Orders.Add(order);
            _context.SaveChanges();

            var cartItems = _cart.CartItems;

            foreach (var item in cartItems)
            {
                var orderdetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    Product = item.Product,
                    Order = order,
                    Price = item.Product.Price
                };
                _context.OrderDetails.Add(orderdetail);
            }
            _context.SaveChanges();
        }
    }
}
