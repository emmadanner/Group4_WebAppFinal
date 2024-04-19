using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{


    [Table("Pokemons")]

    public class Pokemon 
    {
        [Key]
        public  string PokemonName { get; set; }
        
        public int DexNumber { get; set; }
        [MaxLength(100)]
        public  string Type1 { get; set; }
        
        [MaxLength(100)]
        public string? Type2 { get; set; }
        
        public ICollection<PokemonType> PokemonTypes { get; set; } = new List<PokemonType>();

        public  int Generation { get; set; }

        public ICollection<Generation> Generations { get; set; } = new List<Generation>();

        public int? TeamNum { get; set; }
        public ICollection<Team>? Team { get;}
        
    }
}
