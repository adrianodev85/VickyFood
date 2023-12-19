using VickyFood.Infrastructure;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;

namespace VickyFood.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
