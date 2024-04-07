using eticaret_uygula.Data;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class SliderList:ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public SliderList(ApplicationDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()// C#'taki Invoke komutu; bir metodu tetiklemeye yarar.Yani objelere erişimi sağlayabilmek ve değişiklik yapmak için objenin hafızada bir kopyasını oluşturup , değişikliği yapıp, eskisi ile değiştirilmesi işlemine denir.
        {
            var result = _context.Slider.ToList();
            return View(result);
        }
    }
}
