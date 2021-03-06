using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebClientCitas.Services;

namespace WebClientCitas
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredToast();
            builder.Services
                .AddScoped<IAuthServices, AuthServices>();

            builder.Services.AddAuthenticationCore();

            var host = builder.Build();

            var authenticationService = host.Services.GetRequiredService<IAuthServices>();

            await host.RunAsync();

        }
    }
}
