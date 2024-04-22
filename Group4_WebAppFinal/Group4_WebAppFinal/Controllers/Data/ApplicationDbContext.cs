using Group4_WebAppFinal.Controllers.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Group4_WebAppFinal.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Bag> Bags { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Bag>().HasData(

                new Bag { ItemName = "Potion", ItemQuantity = 1, ItemType = "Consumable", Description = "Restores 10HP" }

                );


            modelBuilder.Entity<PokemonType>().HasData(

                new PokemonType { TypeName = "None" },
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
        }
    }
}
