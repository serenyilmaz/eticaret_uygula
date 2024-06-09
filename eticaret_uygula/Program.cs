using eticaret_uygula.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});//baðlantý cümlemiz bu veritabanýna..

builder.Services.AddSession(options =>  //session ayrýca buraya da dahil ettik,
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);  // sepetteki ürünün 30 dakikalýk kalmasýný saðlamak için yazdýk.
    options.Cookie.IsEssential = true;
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();//Bunu buraya yazdýk çünkü eðer siz session'la bir iþlem yapýcaksanýz bu terimi program' ýn içerisine yazmak zorundasýnýz.//
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
