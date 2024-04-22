using Group4_WebAppFinal.Client.Pages;
using Group4_WebAppFinal.Components;
using Group4_WebAppFinal.Controllers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using Group4_WebAppFinal.Model;
using Group4_WebAppFinal.Controllers.Entities;
using System.Security.Cryptography;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PokemonTeamBuilder"));
});



// Add services to the container.
builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri("https://localhost:7294") });
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddFluentUIComponents();

/*builder.Services.AddHttpClient<HttpClient>();*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Group4_WebAppFinal.Client._Imports).Assembly);

app.MapGet("/api/pokemon", async (ApplicationDbContext dbContext) =>
{
    var pokemons = await dbContext.Pokemons.ToListAsync();

    List<PokemonViewModel> pokemonViewModels = new();

    foreach (var pokemon in pokemons)
    {
        pokemonViewModels.Add(new PokemonViewModel
        {
            DexNumberID = pokemon.DexNumberID,
            PokemonName = pokemon.PokemonName,
            Type1 = pokemon.Type1,
            Type2 = pokemon.Type2,
        });
    }

    return Results.Ok(pokemons);
});

app.MapGet("/api/pokemon/{DexNumberID}", async (ApplicationDbContext dbContext, int DexNumberID) =>
{
    var pokemon = await dbContext.Pokemons.FindAsync(DexNumberID);
    if (pokemon == null)
    {
        return Results.NotFound();
    }

    PokemonViewModel pokemonViewModel = new()
    {
        DexNumberID = pokemon.DexNumberID,
        PokemonName = pokemon.PokemonName,
        Type1 = pokemon.Type1,
        Type2 = pokemon.Type2,
    };

    return Results.Ok(pokemon);
});

app.MapPost("/api/pokemon", async (ApplicationDbContext dbContext, PokemonViewModel pokemonViewModel) =>
{
    Pokemon pokemon = new()
    {
        DexNumberID = pokemonViewModel.DexNumberID,
        PokemonName = pokemonViewModel.PokemonName,
        Type1 = pokemonViewModel.Type1,
        Type2 = pokemonViewModel.Type2,
    };

    await dbContext.Pokemons.AddAsync(pokemon);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/api/pokemon/{pokemon.DexNumberID}", pokemon);
});

app.MapDelete("/api/pokemon/{DexNumberID}", async (ApplicationDbContext dbContext, int DexNumberID) =>
{
    var pokemon = await dbContext.Pokemons.FindAsync(DexNumberID);
    if (pokemon == null)
    {
        return Results.NotFound();
    }

    dbContext.Pokemons.Remove(pokemon);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

app.Run();
