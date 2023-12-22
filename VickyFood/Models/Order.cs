using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VickyFood.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string? Surname { get; set; }

        [StringLength(400)]
        [Display(Name = "Address")]
        public string Address1 { get; set; }

        [StringLength(400)]
        [Display(Name = "Complement")]
        public string? Address2 { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(200)]
        public string? State { get; set; }

        [StringLength(200)]
        public string Country { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Total Order")]
        [ScaffoldColumn(false)]
        public decimal TotalOrder { get; set; }

        [Display(Name = "Total Itens in Order")]
        [ScaffoldColumn(false)]
        public int TotalItemsOrder { get; set; }

        [Display(Name = "Order Dispatched")]
        [DataType(DataType.Text)]
        public DateTime OrderDispatched { get; set; }

        [Display(Name = "Order Delivered")]
        [DataType(DataType.Text)]
        public DateTime OrderDelivered { get; set; }


        public List<OrderDetail> OrderItems { get; set; }
    }
}
