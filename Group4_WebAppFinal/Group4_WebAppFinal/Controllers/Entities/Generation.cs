using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{
    [Table("Generations")]
    public class Generation
    {
        public int GenerationId { get; set; }
        public string GenGames { get; set; }
    }
}
