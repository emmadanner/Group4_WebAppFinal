using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{


    [Table("Pokemons")]

    public class Pokemon 
    {
        [Key]
        public string PokemonName { get; set; }
        
        public int DexNumber { get; set; }
        [MaxLength(100)]
        public PokemonType Type1 { get; set; }
        [MaxLength(100)]
        public PokemonType? Type2 { get; set; }
        
        public Generation Generation { get; set; }

        public ICollection<Team> Team { get;}
        
    }
}
