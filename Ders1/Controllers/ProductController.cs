using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
