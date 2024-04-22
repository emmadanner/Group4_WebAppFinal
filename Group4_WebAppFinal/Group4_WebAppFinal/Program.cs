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
            PokemonName = pokemon.PokemonName,
            DexNumberID = pokemon.DexNumberID,
            Type1 = pokemon.Type1,
            Type2 = pokemon.Type2,
        });
    }

    return Results.Ok(pokemons);
});

app.MapGet("/api/pokemon/{id}", async (ApplicationDbContext dbContext, int id) =>
{
    var pokemon = await dbContext.Pokemons.FindAsync(id);
    if (pokemon == null)
    {
        return Results.NotFound();
    }

    PokemonViewModel pokemonViewModel = new()
    {
        PokemonName = pokemon.PokemonName,
        DexNumberID = pokemon.DexNumberID,
        Type1 = pokemon.Type1,
        Type2 = pokemon.Type2,
    };

    return Results.Ok(pokemon);
});

app.MapPost("/api/pokemon", async (ApplicationDbContext dbContext, PokemonViewModel pokemonViewModel) =>
{

    Pokemon pokemon = new()
    {
        PokemonName = pokemonViewModel.PokemonName,
        DexNumberID = pokemonViewModel.DexNumberID,
        Type1 = pokemonViewModel.Type1,
        Type2 = pokemonViewModel.Type2,
    };

    await dbContext.Pokemons.AddAsync(pokemon);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/api/pokemon/{pokemon.PokemonName}", pokemon);
});

app.MapPut("/api/pokemon/{id}", async (ApplicationDbContext dbContext, int id, PokemonViewModel pokemonViewModel) =>
{
    var pokemon = await dbContext.Pokemons.FindAsync(id);
    if (pokemon == null)
    {
        return Results.NotFound();
    }

    pokemon.PokemonName = pokemonViewModel.PokemonName;
    pokemon.DexNumberID = pokemonViewModel.DexNumberID;
    pokemon.Type1 = pokemonViewModel.Type1;
    pokemon.Type2 = pokemonViewModel.Type2;

    await dbContext.SaveChangesAsync();
    return Results.Ok(pokemon);
});



app.MapDelete("/api/pokemon/{id}", async (ApplicationDbContext dbContext, int id) =>
{
    var pokemon = await dbContext.Pokemons.FindAsync(id);
    if (pokemon == null)
    {
        return Results.NotFound();
    }

    dbContext.Pokemons.Remove(pokemon);
    await dbContext.SaveChangesAsync();
    return Results.Ok();
});

app.MapGet("/api/item", async (ApplicationDbContext dbContext) =>
{
    var items = await dbContext.Bags.ToListAsync();

    List<ItemViewModel> itemViewModels = new();

    foreach (var item in items)
    {
        itemViewModels.Add(new ItemViewModel
        {
            ItemName = item.ItemName,
            ItemQuantity = item.ItemQuantity,
            ItemType = item.ItemType,
            Description = item.Description

        });
    }

    return Results.Ok(items);
});

app.MapGet("/api/types", async (ApplicationDbContext dbContext) =>
{
    var typings = await dbContext.PokemonTypes.ToListAsync();

    List<TypeViewModel> typeViewModels = new();

    foreach (var typing in typings)
    {
        typeViewModels.Add(new TypeViewModel
        {
            TypeName = typing.TypeName

        });
    }

    return Results.Ok(typings);
});


app.Run();
