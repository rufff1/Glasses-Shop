using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class ProductImage :BaseEntitiy
    {
        [StringLength(255)]
        public string Name { get; set; }


        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
