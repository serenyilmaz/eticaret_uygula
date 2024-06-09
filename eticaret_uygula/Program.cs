using eticaret_uygula.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});//ba�lant� c�mlemiz bu veritaban�na..

builder.Services.AddSession(options =>  //session ayr�ca buraya da dahil ettik,
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);  // sepetteki �r�n�n 30 dakikal�k kalmas�n� sa�lamak i�in yazd�k.
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
app.UseSession();//Bunu buraya yazd�k ��nk� e�er siz session'la bir i�lem yap�caksan�z bu terimi program' �n i�erisine yazmak zorundas�n�z.//
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
