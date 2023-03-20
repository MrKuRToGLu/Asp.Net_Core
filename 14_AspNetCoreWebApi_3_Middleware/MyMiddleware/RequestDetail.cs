namespace _14_AspNetCoreWebApi_3_Middleware.MyMiddleware
{
    public class RequestDetail
    {
        RequestDelegate _next;
        public RequestDetail(RequestDelegate next)
        {
            _next = next;
        }

        // bir önceki middleware tarafından tetiklenir...
        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;
            if (path == "/api/values")
            {
                // request url'deki isim parametresine bakılır...
                var queryStrings = context.Request.Query; // query stringler alınır
                var queryIsim = context.Request.Query["isim"];
                var queryPwd = context.Request.Query["pwd"];

                if (queryIsim == "ismail" && queryPwd == "123")
                {
                    await _next(context); // sonraki middleware tetiklenir...
                }
                else
                {
                    // await _next(context); // bir sonraki middleware tetiklenir..
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("Dataya Erişim Yetkiniz Yoktur...");
                }
            }
            else
                await _next(context); // sonraki middleware tetiklenir..
        }
    }
}