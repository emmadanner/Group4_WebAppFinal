using Group4_WebAppFinal.Controllers.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Group4_WebAppFinal.Controllers.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Bag>().HasData(
                
                new Bag { ItemName = "Potion", ItemQuantity = 1, ItemType = "Consumable", Description = "Restores 10HP"}

                );
                
            
            modelBuilder.Entity<PokemonType>().HasData(

                new PokemonType { TypeName = "None"},
                new PokemonType { TypeName = "Normal" },
                new PokemonType { TypeName = "Fire" },
                new PokemonType { TypeName = "Water" },
                new PokemonType { TypeName = "Electric" },
                new PokemonType { TypeName = "Grass" },
                new PokemonType { TypeName = "Ice" },
                new PokemonType { TypeName = "Fighting" },
                new PokemonType { TypeName = "Poison" },
                new PokemonType { TypeName = "Ground" },
                new PokemonType { TypeName = "Flying" },
                new PokemonType { TypeName = "Psychic" },
                new PokemonType { TypeName = "Bug" },
                new PokemonType { TypeName = "Rock" },
                new PokemonType { TypeName = "Ghost" },
                new PokemonType { TypeName = "Dragon" },
                new PokemonType { TypeName = "Dark" },
                new PokemonType { TypeName = "Steel" },
                new PokemonType { TypeName = "Fairy" }
                );

            modelBuilder.Entity<Generation>().HasData(
                
                new Generation { GenerationId = 1, GenGames = "Red, Blue, Green, Yellow"},
                new Generation { GenerationId = 2, GenGames = "Gold, Silver, Crystal" },
                new Generation { GenerationId = 3, GenGames = "Ruby, Sapphire, Emerald, FireRed, LeafGreen" },
                new Generation { GenerationId = 4, GenGames = "Diamond, Pearl, Platinum, HeartGold, SoulSilver" },
                new Generation { GenerationId = 5, GenGames = "Black, White, Black 2, White 2" },
                new Generation { GenerationId = 6, GenGames = "X, Y, Omega Ruby, Alpha Sapphire" },
                new Generation { GenerationId = 7, GenGames = "Sun, Moon, Ultra Sun, Ultra Moon" },
                new Generation { GenerationId = 8, GenGames = "Sword, Shield, Brilliant Diamond, Shining Pearl" },
                new Generation { GenerationId = 9, GenGames = "Scarlet, Violet" }
                );
            

            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon { PokemonName = "Bulbasaur", DexNumber = 001, Type1 = "Grass", Type2 = "Poison", Generation = 1, TeamNum = 1},
                new Pokemon { PokemonName = "Lileep", DexNumber = 345, Type1 = "Rock", Type2 = "Grass", Generation = 3 }
                );
        }




    }
}
