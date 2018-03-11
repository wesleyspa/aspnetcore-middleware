using System;
using System.IO;
using Console;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ASP.NET_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
               .UseKestrel()
               .UseStartup<Startup>()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .Build();
            host.Run();
        }
    }
}
