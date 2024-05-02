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

        public IActionResult CityList()
        {
            var city_ = new List<City>
            {
                new City {CityCode="01" , CityName="ADANA"},
            new City {CityCode="02" , CityName="ADIYAMAN"},
            new City {CityCode="03" , CityName="AFYONKARAHİSAR"},
            new City {CityCode="04" , CityName="AĞRI"},
            new City {CityCode="05" , CityName="AMASYA"},
            new City {CityCode="06" , CityName="ANKARA"},
            new City {CityCode="07" , CityName="ANTALYA"},
            new City {CityCode="08" , CityName="ARTVİN"},
            new City {CityCode="09" , CityName="AYDIN"},
            new City {CityCode="10" , CityName="BALIKESİR"},
            new City {CityCode="11" , CityName="BİLECİK"},
            new City {CityCode="12" , CityName="BİNGÖL"},
            new City {CityCode="13" , CityName="BİTLİS"},
            new City {CityCode="14" , CityName="BOLU"},
            new City {CityCode="15" , CityName="BURDUR"},
            new City {CityCode="16" , CityName="BURSA"},
            new City {CityCode="17" , CityName="ÇANAKKALE"},
            new City {CityCode="18" , CityName="ÇANKIRI"},
            new City {CityCode="19" , CityName="ÇORUM"},
            new City {CityCode="20" , CityName="DENİZLİ"},
            new City {CityCode="21" , CityName="DİYARBAKIR"},
            new City {CityCode="22" , CityName="EDİRNE"},
            new City {CityCode="23" , CityName="ELAZIĞ"},
            new City {CityCode="24" , CityName="ERZİNCAN"},
            new City {CityCode="25" , CityName="ERZURUM"},
            new City {CityCode="26" , CityName="ESKİŞEHİR"},
            new City {CityCode="27" , CityName="GAZİANTEP"},
            new City {CityCode="28" , CityName="GİRESUN"},
            new City {CityCode="29" , CityName="GÜMÜŞHANE"},
            new City {CityCode="30" , CityName="HAKKARİ"},
            new City {CityCode="31" , CityName="HATAY"},
            new City {CityCode="32" , CityName="ISPARTA"},
            new City {CityCode="33" , CityName="MERSİN"},
            new City {CityCode="34" , CityName="İSTANBUL"},
            new City {CityCode="35" , CityName="İZMİR"},
            new City {CityCode="36" , CityName="KARS"},
            new City {CityCode="37" , CityName="KASTAMONU"},
            new City {CityCode="38" , CityName="KAYSERİ"},
            new City {CityCode="39" , CityName="KIRKLARELİ"},
            new City {CityCode="40" , CityName="KIRŞEHİR"},
            new City {CityCode="41" , CityName="KOCAELİ (İZMİT)"},
            new City {CityCode="42" , CityName="KONYA"},
            new City {CityCode="43" , CityName="KÜTAHYA"},
            new City {CityCode="44" , CityName="MALATYA"},
            new City {CityCode="45" , CityName="MANİSA"},
            new City {CityCode="46" , CityName="KAHRAMANMARAŞ"},
            new City {CityCode="47" , CityName="MARDİN"},
            new City {CityCode="48" , CityName="MUĞLA"},
            new City {CityCode="49" , CityName="MUŞ"},
            new City {CityCode="50" , CityName="NEVŞEHİR"},
            new City {CityCode="51" , CityName="NİĞDE"},
            new City {CityCode="52" , CityName="ORDU"},
            new City {CityCode="53" , CityName="RİZE"},
            new City {CityCode="54" , CityName="SAKARYA (ADAPAZARI)"},
            new City {CityCode="55" , CityName="SAMSUN"},
            new City {CityCode="56" , CityName="SİİRT"},
            new City {CityCode="57" , CityName="SİNOP"},
            new City {CityCode="58" , CityName="SİVAS"},
            new City {CityCode="59" , CityName="TEKİRDAĞ"},
            new City {CityCode="60" , CityName="TOKAT"},
            new City {CityCode="61" , CityName="TRABZON"},
            new City {CityCode="62" , CityName="TUNCELİ"},
            new City {CityCode="63" , CityName="ŞANLIURFA"},
            new City {CityCode="64" , CityName="UŞAK"},
            new City {CityCode="65" , CityName="VAN"},
            new City {CityCode="66" , CityName="YOZGAT"},
            new City {CityCode="67" , CityName="ZONGULDAK"},
            new City {CityCode="68" , CityName="AKSARAY"},
            new City {CityCode="69" , CityName="BAYBURT"},
            new City {CityCode="70" , CityName="KARAMAN"},
            new City {CityCode="71" , CityName="KIRIKKALE"},
            new City {CityCode="72" , CityName="BATMAN"},
            new City {CityCode="73" , CityName="ŞIRNAK"},
            new City {CityCode="74" , CityName="BARTIN"},
            new City {CityCode="75" , CityName="ARDAHAN"},
            new City {CityCode="76" , CityName="IĞDIR"},
            new City {CityCode="77" , CityName="YALOVA"},
            new City {CityCode="78" , CityName="KARABÜK"},
            new City {CityCode="79" , CityName="KİLİS"},
            new City {CityCode="80" , CityName="OSMANİYE"},
            new City {CityCode="81" , CityName="DÜZCE"}

            };

            return View(city_);
        }



    }
}
