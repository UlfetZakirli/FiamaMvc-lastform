using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Category:BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string CategoryName { get; set; }
        public string? CategoryIcon { get; set; }
        public bool IsDeleted { get; set; }
    }
}
