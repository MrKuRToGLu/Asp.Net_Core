using _14_AspNetCoreWebApi_4_JwtToken.Models.Entites;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(c =>
{
    c.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = "JwtTokenServerApplication.com",
        ValidateAudience = false,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("benbuservisinsecuritykeyiyim")),
        ClockSkew = TimeSpan.Zero
    };
}); //client'In gönderdiði tokenýn doðrulanmasý...

builder.Services.AddDbContext<NorthwindContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("con"));
});

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
