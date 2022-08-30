
namespace WebApi.Middlewares
{
    public class TimeMiddlewares
    {
        readonly RequestDelegate next;

        //Constructor
        public TimeMiddlewares(RequestDelegate nextRequest)
        {
            next = nextRequest;
        }   

        public async Task Invoke(HttpContext context)
        {
            await next(context);
            if (context.Request.Query.Any(p => p.Key == "time"))//http://localhost:5114/api/WeatherForecast/GetList?time
            {
                await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
            }   
        }
    }
    public static class TimeMiddlewareExtension
    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMiddlewares>();
        }
    }
}

