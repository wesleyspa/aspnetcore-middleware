using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Console
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<MyMiddleware>();
            app.Run(context => context.Response.WriteAsync("Olá mundo 2!"));
        }
    }
}