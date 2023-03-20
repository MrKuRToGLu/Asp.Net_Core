var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute("product",
      "Urun/{ProductName}-{ProductId}/Detay",
      defaults: new { controller = "Product", action = "Detail" });

app.MapControllerRoute("product",
      "Urun/{categoryName}-{categoryId}",
      defaults: new { controller = "Product", action = "Index" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//});

app.Run();
