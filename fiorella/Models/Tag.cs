using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Tag :BaseEntitiy
    {
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public IEnumerable<BlogTag> BlogTags { get; set; }
    }
}
