using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group4_WebAppFinal.Controllers.Entities
{
    [Table("Bags")]
    public class Bag
    {
        
        [Key] [MaxLength(100)]
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        [MaxLength(100)]
        public string? ItemType { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
