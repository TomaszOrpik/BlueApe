using Blazored.LocalStorage;
using BlueApeUI.Contracts;
using BlueApeUI.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Authorization;
using BlueApeUI.Providers;
using System.Text;
using System.Threading.Tasks;
using Tewr.Blazor.FileReader;
using Newtonsoft.Json;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;
using BlueApeUI.Models;
using System.Reflection;

namespace BlueApeUI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddFileReaderService(options => {
                options.UseWasmSharedBuffer = true;
            });

            var http = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            builder.Services.AddScoped(sp => http);
            string requestUri = builder.HostEnvironment.IsProduction()
                ? "appsettings.production.json"
                : "appsettings.json";
            using var response = await http.GetAsync(requestUri);
            using var stream = await response.Content.ReadAsStreamAsync();
            builder.Configuration.AddJsonStream(stream);
            var apiUrls = builder.Configuration.GetSection("ApiUrls");

            builder.Services.AddHttpClient("baseClient", client => {
                string uri = apiUrls.GetSection("baseApi").Value != ""
                    ? apiUrls.GetSection("baseApi").Value
                    : builder.HostEnvironment.BaseAddress;
                client.BaseAddress = new Uri(uri);
            });
            builder.Services.AddHttpClient("fileClient", client => {
                client.BaseAddress = new Uri(apiUrls.GetSection("fileApi").Value);
            });

            builder.Services.AddScoped<ApiAuthenticationProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(p =>
                p.GetRequiredService<ApiAuthenticationProvider>());
            builder.Services.AddScoped<JwtSecurityTokenHandler>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddTransient<IAuthenticationRepository, AuthenticationRepository>();
            builder.Services.AddTransient<IFileManagerRepository, FileManagerRepository>();
            builder.Services.AddTransient<IBlogsManagerRepository, BlogsManagerRepository>();
            await builder.Build().RunAsync();
        }
    }
}
