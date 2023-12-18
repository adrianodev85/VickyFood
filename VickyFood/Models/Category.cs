using System.ComponentModel.DataAnnotations;

namespace VickyFood.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        [StringLength(100, ErrorMessage = "Maximum length is 100 characters")]
        public string CategoryName { get; set; }

        [Display(Name = "Active?")]
        public bool CategoryActive { get; set; }
        public List<Product> Products { get; set; }
    }
}
