using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{
    [Table("Teams")]
    public class Team
    {
        public int TeamId { get; set; }
        public Pokemon Pokemon { get; set; }
        [MaxLength(100)]
        public Bag Bag { get; set; }

        
        
    }
}
