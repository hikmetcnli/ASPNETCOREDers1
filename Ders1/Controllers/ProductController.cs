using Ders1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Ders1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var product_ = new List<Product>
            {
                new Product { Id = 1,ProductName="Kalem",Category="Kırtasiye",Price=5},
                new Product { Id = 2,ProductName="Silgi",Category="Kırtasiye",Price=3},
                new Product { Id = 3,ProductName="Defter",Category="Kırtasiye",Price=7},
                new Product { Id = 4,ProductName="Cetvel",Category="Kırtasiye",Price=10}
            };

            //var iller = new List<string> { "Adana", "Düzce" };
            //var sayilar = new List<int> { 1,81 };

            return View(product_);
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
