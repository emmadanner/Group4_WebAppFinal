using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_WebAppFinal.Model
{
    public class PokemonViewModel
    {
        [Key]
        public int DexNumberID { get; set; }
        public  string PokemonName { get; set; }

        [MaxLength(100)]
        public  string Type1 { get; set; }

        [MaxLength(100)]
        public string? Type2 { get; set; }

        public ICollection<TypeViewModel> PokemonTypes { get; set; } = new List<TypeViewModel>();

    }
}
