using Microsoft.AspNetCore.Mvc;

namespace VickyFood.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
