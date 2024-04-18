using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri("https://localhost:7104") });

builder.Services.AddSingleton<HttpClient>(new HttpClient { BaseAddress = new Uri("https://localhost:7104") });

await builder.Build().RunAsync();
