var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSession(conf =>
{
    conf.IdleTimeout = TimeSpan.FromMinutes(1); // 1 dakika...
});

var app = builder.Build();


app.UseSession();

//app.MapGet("/", () => "Hello World!");
app.UseRouting();

app.UseEndpoints(c =>
{
    c.MapControllerRoute("default",
        "{controller=home}/{action=index}"
        );
});

app.Run();
