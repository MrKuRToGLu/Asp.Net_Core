using _11_DependencyInjection2.models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<NorthWindContext>();

builder.Services.AddScoped<NorthWindContext>(); // instance oluþturulur ve konteynar'a eklenir(register). constructor'dan kim instance bekliyorsa o container'dan instance alýr...


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.UseRouting();
app.MapControllerRoute("defauly",
    "{controller=home}/{action=index}");

app.Run();
