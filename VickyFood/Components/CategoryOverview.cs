using Microsoft.AspNetCore.Mvc;
using VickyFood.Repositories.Interfaces;

namespace VickyFood.Components
{
    public class CategoryOverview : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryOverview(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(p => p.CategoryName);
            return View(categories);
        }
    }
}
