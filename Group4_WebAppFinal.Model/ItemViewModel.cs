using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_WebAppFinal.Model
{
    public class ItemViewModel
    {
        [Key]
        public ICollection<TypeViewModel> Bags { get; set; } = new List<TypeViewModel>();
        public int BagID { get; set; }
        [MaxLength(100)]
        public required string ItemName { get; set; }

        [MaxLength(100)]
        public string? ItemType { get; set; }

        [MaxLength(100)]
        public int? ItemQuantity { get; set; }
        public required string Description { get; set; }
    }
}
