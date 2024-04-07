using eticaret_uygula.Data;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class TrendList:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public TrendList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var result = _context.Products.ToList();
            return View(result); // aynı ada sahip View veya parametre olarka geçilen view’i geri döndüren Result türüdür.
        }
    }
}
