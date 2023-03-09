using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("app");

builder.Services.AddSingleton<WeatherForecastService>();

await builder.Build().RunAsync();