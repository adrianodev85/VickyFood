using System.ComponentModel.DataAnnotations.Schema;

namespace VickyFood.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }


        public int Amount { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }


        public Product Product { get; set; }


        public Order Order { get; set; }
    }
}
