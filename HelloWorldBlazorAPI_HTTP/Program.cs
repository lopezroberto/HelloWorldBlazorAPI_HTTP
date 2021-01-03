// https://wheretheiss.at/w/developer
//http://open-notify.org/Open-Notify-API/ISS-Location-Now/
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBlazorAPI_HTTP
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            builder.Services.AddHttpClient("ISSLocation", client => {
                client.BaseAddress = new Uri("https://api.wheretheiss.at/v1/satellites/25544");
            });


            await builder.Build().RunAsync();
        }
    }
}
