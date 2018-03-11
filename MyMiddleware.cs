using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class MyMiddleware
{
    private RequestDelegate _next;

    public MyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        //Request
        var start = DateTime.Now;

        await _next(context);

        var finish = DateTime.Now;
        var diff = finish.Subtract(start);
        await context.Response.WriteAsync($"The time was {diff.Milliseconds}");
        //Response
    }
}
