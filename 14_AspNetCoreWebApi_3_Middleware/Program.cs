using _14_AspNetCoreWebApi_3_Middleware.MyMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

#region "Middleware"


// 3 adet middleware vardýr..

//app.Use();
//app.Map();
//app.Run(); // kýsa devre middleware

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Test 1");
//    await next(context); // birsonraki middleware tetiklenir...
//    await context.Response.WriteAsync("Test 2");
//});
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Test 3");
//    await next(context); // bir sonraki middleware tetiklendir
//});
//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Merhaba Deneme");
//});
//app.MapGet("/api/home", () => "hello world");
#endregion




// custom middleware tetiklenir...
app.UseMiddleware<RequestDetail>();

app.MapControllers();

app.Run();