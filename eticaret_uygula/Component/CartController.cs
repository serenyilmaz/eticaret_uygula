using eticaret_uygula.Data;
using eticaret_uygula.Dto;
using eticaret_uygula.Models;
using eticaret_uygula.Oturum;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace eticaret_uygula.Component
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CartItem> items = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartViewModel cartvm = new()
            {
                CartItems =  items,
                GrandTotal = items.Sum(x => x.Quantity * x.Price)


            };

            return View(cartvm);
        }
        public async Task <IActionResult> Add(int id)
        {
            Products product = _context.Products.Find(id);
            List<CartItem> items = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = items.FirstOrDefault(x => x.ProductId == id);
            if (cartItem == null)
            {
                items.Add(new CartItem(product));
            }
            else
            {
                cartItem.Quantity += 1;
            }
            HttpContext.Session.SetJson("Cart", items);
            TempData["Mesaj"] = "Ürün Sepete Eklenmiştir.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
