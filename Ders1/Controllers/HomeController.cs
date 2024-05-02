using Ders1.Models;
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


        public IActionResult Book()
        {
            string Title = "<br /><h4>Yazılım Kitap Listesi</h4><br />";
            ViewBag.d1 = Title;

            var book_ = new List<Book>
            {
                new Book {Id=1,BookName="C# Kitabı",Writer="Hikmet CANLI"},
                new Book {Id=2,BookName="VB.NET Kitabı",Writer="Sinan TOKLU"},
                new Book {Id=3,BookName="Java Kitabı",Writer="Mehmet Ali Akçayol"},
			};



            return View(book_);
        }



    }
}
