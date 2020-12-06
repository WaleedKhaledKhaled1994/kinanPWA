using System;
using System.Net.Http;

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorMovies.Client.Auth;
using PWA.Client.Repositories.Interface;
using PWA.Client.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using PWA.Client.Auth;
using PWA.Client.Helpers;
using PWA.Client.Repositories.Interfaces;
using Blazor.FileReader;

namespace PWA.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IHttpService, HttpService>();


            //Add Image
            builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
            
            builder.Services.AddScoped<JWTAuthenticationStateProvider>();
            builder.Services.AddScoped<IAccounts, AccountsRepository>();
            builder.Services.AddScoped<ICategory, CategoryRepository>();
            builder.Services.AddScoped<ISubCategory, SubCategoryRepository>();
            builder.Services.AddScoped<IProduct, ProductRepository>();
            builder.Services.AddScoped<IUser, UserRepository>();


            //Add Authintication
            builder.Services.AddAuthorizationCore();

            builder.Services.AddTelerikBlazor();

            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                         provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());
            builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());

            await builder.Build().RunAsync();
        }
    }
}
