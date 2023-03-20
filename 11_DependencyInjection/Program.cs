using _11_DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

#region "Asp.Net Core Dependecny Injection"

// asp.net core ile birlikte built-in (dahili) dependecnt injection modülü geliþtirilmiþtir...baðýmlýklýklar aþaðýdaki metotlar ile enjecte edilebilir;

// AddTransient
// AddScoped
// AddSingleton

// Yukarýdaki metotlar ile instance oluþtulurur...
#endregion

//IMessage m = new MessageTR();
// instance register

// dependency injection uygulanmasý...
builder.Services.AddScoped<IMessage, MessageEng>();

builder.Services.AddTransient<IOgrenci, Tembeller>(); // IOgrenci i = new Tembeller();
builder.Services.AddTransient<IOgrenci, Caliskanlar>();

// instance servisi ayaða kaldýrýlýr...Asp.Net core'de instancelar services içerisine eklenir...bu yüzden buradan enjecte edilen yapýlara servis denir...

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.UseEndpoints(endpoints =>
    endpoints.MapControllerRoute("default"
    , "{controller=home}/{action=index}")
);

app.Run();
