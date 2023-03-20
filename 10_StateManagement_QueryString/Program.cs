var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.UseEndpoints(c =>
{
    // multiple route...

    c.MapControllerRoute(
   "default1",
   "Home/Demo/{isim}",
   new { controller = "Home", action = "Demo" });

    c.MapControllerRoute(
        "sayfarota",
        "{controller}/{action}/{isim}-{soyisim}",
       defaults: new { controller = "Home", action = "Sayfa" }
        );

    c.MapControllerRoute(
        "default",
        //"{controller=home}/{action=index}",
        "{controller}/{action}",
       defaults: new { controller = "Home", action = "index" }
        );


});


app.Run();
