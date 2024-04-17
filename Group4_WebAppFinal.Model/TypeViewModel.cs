using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_WebAppFinal.Model
{
    public class TypeViewModel
    {
        [Key]
        [MaxLength(100)]
        public required string TypeName { get; set; }
    }
}
