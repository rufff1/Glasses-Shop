using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class ProductColor :BaseEntitiy
    {
        public Color Color { get; set; }
        public int ColorId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
