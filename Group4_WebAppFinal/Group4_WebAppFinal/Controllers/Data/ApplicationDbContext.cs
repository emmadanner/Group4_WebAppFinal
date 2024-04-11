using Group4_WebAppFinal.Controllers.Entities;
using Microsoft.EntityFrameworkCore;

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

        
    }
}
