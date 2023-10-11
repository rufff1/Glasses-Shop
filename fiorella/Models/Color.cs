using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Color :BaseEntitiy

    {
        public string Name { get; set; }
        public string HTax { get; set; }


        public IEnumerable<Product> Products { get; set; }

    }
}
