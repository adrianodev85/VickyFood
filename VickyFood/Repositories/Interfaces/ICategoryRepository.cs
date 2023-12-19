using VickyFood.Models;

namespace VickyFood.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
