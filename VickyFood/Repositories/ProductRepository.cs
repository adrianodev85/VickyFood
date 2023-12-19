using Microsoft.EntityFrameworkCore;
using VickyFood.Infrastructure;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;

namespace VickyFood.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products => _context.Products.Include(p => p.Category);

        public IEnumerable<Product> FavoriteProducts => _context.Products.Where(p => p.ProductFavorite).Include(p => p.Category);

        public Product ProductGetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
