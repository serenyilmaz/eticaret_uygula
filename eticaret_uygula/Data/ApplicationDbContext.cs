using eticaret_uygula.Models;
using Microsoft.EntityFrameworkCore;

namespace eticaret_uygula.Data
{
    public class ApplicationDbContext : DbContext//veritabanımaızla bağlantımızı kurduk.
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)//DbContext ayarlarını yaptık.
        {
        }
        public DbSet<Category> ?Categories { get; set; }
        public DbSet<Products>? Products { get; set; }
        public DbSet<slider>? Slider { get; set; }
    }
}
