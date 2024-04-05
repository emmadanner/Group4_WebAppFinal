using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{
    [Table("PokemonTypes")]
    public class PokemonType
    {
        [Key]
        [MaxLength(100)]
        public string TypeName { get; set; }
    }
}
