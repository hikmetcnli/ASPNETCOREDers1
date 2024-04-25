using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Sum()
        {
            return "15";
        }
        public string Sum2()
        {
            return "15";
        }


    }
}
