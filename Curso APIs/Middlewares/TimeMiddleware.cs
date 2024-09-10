public class TimeMiddlewares
{
    //Sirve para invorcar el Middlewares que sigue
    readonly RequestDelegate next;

    //constructor
    public TimeMiddlewares(RequestDelegate nextRequest)
    {
        next = nextRequest;
    }

    public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
    {
       
        await next(context);

        if (context.Request.Query.Any(p => p.Key == "time"))
        {
            await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
        }
    }
    

}

// Se agrega a la configuracion del Aoi
public static class TimeMiddlewaresExtension
{
    public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TimeMiddlewares>();
    }
}