var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();
//app.MapGet("/Ogrenci", () => "Hello World!");
app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}"
    );
app.Run();
