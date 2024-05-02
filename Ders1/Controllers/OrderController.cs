using Microsoft.AspNetCore.Mvc;

namespace Ders1.Controllers
{
	public class OrderController : Controller
	{ 
		
		public IActionResult Index()
		{
			//string param = HttpContext.Request.Query["param1"].ToString(); 

			return View();
		}
	}
}
