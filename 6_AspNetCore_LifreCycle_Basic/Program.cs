var builder = WebApplication.CreateBuilder(args);


// servis
builder.Services.AddControllersWithViews(); // Controller servisi container'a eklenir...

var app = builder.Build();

app.UseStaticFiles();

// Middleware 
app.UseRouting(); // Rota çözümlenir

app.MapGet("/Product", () => "Hello World!");
app.MapControllerRoute( // rota eþleþtirilir...
    "Default",// 
    "{controller=Home}/{action=Index}"
    );

app.Run();


// Controller/Action
//Route
//Home/Index
//Product/Index