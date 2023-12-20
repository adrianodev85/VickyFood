using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VickyFood.Models;
using VickyFood.Repositories.Interfaces;
using VickyFood.ViewModels;

namespace VickyFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeVM = new HomeViewModel()
            {
                FavoriteProducts = _productRepository.FavoriteProducts
            };
            return View(homeVM);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
