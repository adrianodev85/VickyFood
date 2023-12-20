using System.ComponentModel.DataAnnotations;

namespace VickyFood.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        [StringLength(200)]
        public string CartId { get; set; }
    }
}
