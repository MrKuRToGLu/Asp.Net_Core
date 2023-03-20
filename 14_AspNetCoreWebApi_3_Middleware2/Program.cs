using _14_AspNetCoreWebApi_3_Middleware2.MyMiddleware;
using _14_AspNetCoreWebApi_3_Middleware2.MyExtensions;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();


app.UseAuthentication();
//app.UseMiddleware<CheckHeaderMiddleware>();
app.UseCheckHeader(); // CustomMiddleware...IApplicationBuilder interface'sine extend edilmiþ metodumuz...


// Configure the HTTP request pipeline.
app.MapControllers();
app.Run();

