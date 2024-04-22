using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{


    [Table("Pokemons")]

    public class Pokemon 
    {
        [Key]
        public int DexNumberID { get; set; }
        public  string PokemonName { get; set; }
        
        [MaxLength(100)]
        public  string Type1 { get; set; }
        
        [MaxLength(100)]
        public string? Type2 { get; set; }
        
        public ICollection<PokemonType> PokemonTypes { get; set; } = new List<PokemonType>();
        
    }
}
