using _14_AspNetCoreWebApi_3_Middleware2.MyMiddleware;

namespace _14_AspNetCoreWebApi_3_Middleware2.MyExtensions
{
    public static class CheckAppMyHeaderExtension
    {
        // extension metot
        public static IApplicationBuilder UseCheckHeader(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CheckHeaderMiddleware>();
        }
    }
}
