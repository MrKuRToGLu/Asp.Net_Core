using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddJsonOptions(c =>
{
    c.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddDbContext<NorthwindContext>(options =>
{
    //options.UseSqlServer("Server=.; Database=Northwind;uid=sa;pwd=123;TrustServerCertificate=true");
    options.UseSqlServer(builder.Configuration.GetConnectionString("myCon"));
});

builder.Services.AddDbContext<AppIdentityDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("iCon"));
});

builder.Services.AddIdentity<AppUser, IdentityRole<int>>(options =>
{
    options.Password.RequiredLength = 3;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddErrorDescriber<CustomError>(); // manager sýnýflarý için...

builder.Services.ConfigureApplicationCookie(conf =>
{
    conf.LoginPath = "/Account/LogIn";
    conf.Cookie.HttpOnly = true;
    conf.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    conf.AccessDeniedPath = "/Permission/Index";
});

var app = builder.Build();
//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.UseAuthentication(); // oturum middleware
app.UseAuthorization(); // yetki middleware

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapControllerRoute("default",
    "{controller=home}/{action=index}");

app.Run();
