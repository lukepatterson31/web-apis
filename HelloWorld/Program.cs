using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .ConfigureLogging(loggingBuilder =>
                            loggingBuilder.AddJsonConsole(options =>
                            {
                                options.IncludeScopes = false;
                                options.TimestampFormat = "hh:mm:ss:fff";
                                options.JsonWriterOptions = new JsonWriterOptions
                                {
                                    Indented = true
                                };

                            }));
                
    }
}
