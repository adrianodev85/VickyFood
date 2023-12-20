using VickyFood.Models;

namespace VickyFood.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> FavoriteProducts { get; set; }
    }
}
