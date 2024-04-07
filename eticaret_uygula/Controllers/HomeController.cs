using eticaret_uygula.Data;
using eticaret_uygula.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eticaret_uygula.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context; //Veri Tabanına bağlanmak için bu yapıyı yazdık.
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)//bu yapıyıda ekledik.
        {
            _logger = logger;
            _context = context;//bu yapıyıda buaraya ekledik veri tabanına bağlantı için.
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detay(int id)
        {
            var result = _context.Products.Find(id);//Veri tabanı içerisindeki Product ı bul Id numarasını göre.
            return View(result);// Result Veriyi geri gönder demek.
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
