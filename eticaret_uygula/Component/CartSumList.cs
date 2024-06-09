using eticaret_uygula.Data;
using eticaret_uygula.Dto;
using eticaret_uygula.Models;
using eticaret_uygula.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class CartSumList:ViewComponent
    {
        private readonly ApplicationDbContext _context;//Veri tabanı bağlantı cümlemiz.

        public CartSumList(ApplicationDbContext context)//Veriyi tanımlartanımlamaz veritabanına bağlansın.
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();//Carttaki listemizi getirip,
            CartViewModel cartVm = new()//cart model içerisindeki,
            {
                CartItems = cart,//cart değerimizi getirip
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)//Carttaki tyoplam değeri  getirdik.
            };
            return View(cartVm);//sayfamızı çağırdık veya sayfamıza gönderdik..
        }
    }
}
