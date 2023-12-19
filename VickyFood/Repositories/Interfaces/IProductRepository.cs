using VickyFood.Models;

namespace VickyFood.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> FavoriteProducts { get; }

        Product ProductGetById(int id);
    }
}
