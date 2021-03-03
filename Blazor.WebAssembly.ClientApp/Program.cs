using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.WebAssembly.ClientApp.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.WebAssembly.ClientApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped<ToastService>();
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
                //BaseAddress = new Uri("http://localhost:5001")
            });

            await builder.Build().RunAsync();
        }
    }
}
