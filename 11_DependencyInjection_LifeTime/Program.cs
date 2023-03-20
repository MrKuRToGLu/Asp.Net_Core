using _11_DependencyInjection_LifeTime.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


// AddTransient => sürekli yeni instance oluþturur
builder.Services.AddTransient<MyClass>();

// AddScoped =>geçerli request için instance oluþturur...
//builder.Services.AddScoped<MyClass>();

// AddSingleton => uygulamanýn yaþam süreci boyunca tek bir instance oluþturur. çok dikkatli kullanýlmasý gerekir...
//builder.Services.AddSingleton<MyClass>();


var app = builder.Build();

app.MapControllerRoute("default",
    "{controller=home}/{action=index}");

app.Run();
