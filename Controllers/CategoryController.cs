using Microsoft.AspNetCore.Mvc;

namespace VoHongHai.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
