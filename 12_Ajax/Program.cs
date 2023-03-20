var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddJsonOptions(action =>
{
    action.JsonSerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("default"
    , "{controller=home}/{action=index}");

app.Run();
