using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class ProtuctTag :BaseEntitiy
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }

        public PTag PTag { get; set; }
        public int PTagId { get; set; }
    }
}
