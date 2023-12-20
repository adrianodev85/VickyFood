using Microsoft.EntityFrameworkCore;
using VickyFood.Infrastructure;

namespace VickyFood.Models
{
    public class Cart
    {
        private readonly AppDbContext _context;

        public Cart(AppDbContext context)
        {
            _context = context;
        }

        public string CartId { get; set; }
        public List<CartItem> CartItems { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            //define session
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            //get context service
            var context = services.GetService<AppDbContext>();
            //get or create cart id
            string cartId = session.GetString("cartId")??Guid.NewGuid().ToString();
            //add id to cart in session
            session.SetString("CartId", cartId);
            //return cart with context and id
            return new Cart(context)
            {
                CartId = cartId
            };
        }
        public void AddToCart(Product product)
        {
            var cartItem = _context.CartItems.SingleOrDefault(
                c => c.Product.ProductId == product.ProductId && c.CartId == CartId);

            if(cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = CartId,
                    Product = product,
                    Amount = 1
                };
                _context.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Amount++;
            }
            
            _context.SaveChanges();
        }
        public void RemoveFromCart(Product product)
        {
            var cartItem = _context.CartItems.SingleOrDefault(
                c => c.Product.ProductId == product.ProductId && c.CartId == CartId);

            if(cartItem != null)
            {
                if(cartItem.Amount > 1)
                {
                    cartItem.Amount--;
                }
                else
                {
                    _context.CartItems.Remove(cartItem);
                }
            }

            _context.SaveChanges();
        }
        public List<CartItem> GetCartItems()
        {
            return CartItems ?? (CartItems = _context.CartItems
                .Where(c => c.CartId == CartId)
                .Include(c => c.Product)
                .ToList());
        }
        public void CleanCart()
        {
            var cartItems = _context.CartItems.Where(c => c.CartId == CartId);
            _context.CartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }
        public decimal GetCartTotal()
        {
            return _context.CartItems.Where(c => c.CartId == CartId)
                .Select(c => c.Product.Price * c.Amount).Sum();
        }

    }
}
