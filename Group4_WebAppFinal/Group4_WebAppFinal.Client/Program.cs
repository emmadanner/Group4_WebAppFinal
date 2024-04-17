using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri("https://localhost:7294") });

await builder.Build().RunAsync();
