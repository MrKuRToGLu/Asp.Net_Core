namespace _7_ViewComponents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}"
                );

            //app.MapGet("/", () => "Hello World!");
            app.Run();
        }
    }
}