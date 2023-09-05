using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class BlogTag : BaseEntitiy
    {
        public Blog Blog { get; set; }
        public int BlogId { get; set; }

        public Tag Tag { get; set; }
        public int TagId { get; set; }
    }
}
