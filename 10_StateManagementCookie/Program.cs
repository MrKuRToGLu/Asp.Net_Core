var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(c=> {
    c.MapControllerRoute("default",
        "{controller=Login}/{action=index}"
        );
    });

app.Run();

