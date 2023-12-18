using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VickyFood.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Product")]
        [StringLength(100, ErrorMessage = "Maximum Length is 100 Characters")]
        public string ProductName { get; set; }

        [Display(Name = "Short Description")]
        [StringLength(200, ErrorMessage = "Maximum length is 200 characters")]
        public string ProductShortDescription { get; set; }

        [Display(Name = "Long Description")]
        [StringLength(400, ErrorMessage = "Maximum length is 400 characters")]
        public string ProductLongDescription { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "The price must be between 1 and 999.99")]
        public decimal Price { get; set; }

        [Display(Name = "Image File Path")]
        [StringLength(150, ErrorMessage = "Maximum Length is 150 Characters")]
        public string UrlImage { get; set; }

        [Display(Name = "Thumbnail File Path")]
        [StringLength(150, ErrorMessage = "Maximum Length is 150 Characters")]
        public string UrlThumbnail { get; set; }

        [Display(Name = "Stock?")]
        public bool ProductStock { get; set; }

        [Display(Name = "Favorite?")]
        public bool ProductFavorite { get; set; }


        public Category Category { get; set; }
    }
}
