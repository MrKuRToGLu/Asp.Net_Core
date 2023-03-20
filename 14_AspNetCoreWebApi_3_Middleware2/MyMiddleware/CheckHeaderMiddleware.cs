using Microsoft.Extensions.Primitives;

namespace _14_AspNetCoreWebApi_3_Middleware2.MyMiddleware
{
    public class CheckHeaderMiddleware
    {

        RequestDelegate delagete;
        public CheckHeaderMiddleware(RequestDelegate delagete)
        {
            this.delagete = delagete;
        }

        public async Task Invoke(HttpContext context)
        {
            // request detayları
            string path = context.Request.Path;
            string metod = context.Request.Method;
            var query = context.Request.Query;
            var header = context.Request.Headers;
            var body = context.Request.Body;

            //using (StreamReader rdr = new StreamReader(body))
            //{
            //    string bodystr = rdr.ReadToEnd();
            //}

            // yukarıdaki bilgileri logla..

            // header'dan gönderilen ApiKey'i oku..
            header.TryGetValue("ApiKey", out StringValues apiKey);
            if (!String.IsNullOrEmpty(apiKey))
            {
                if (apiKey == "123456789")
                {
                    await delagete(context);
                }
                else
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("Tanımıdağımız Api key. Sen Kimsin????");
                }
            }
            else
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Güvenlik için eksik parametre gönderdiniz. Lütfen Api Key'i ekleyiniz");
            }
        }
    }
}