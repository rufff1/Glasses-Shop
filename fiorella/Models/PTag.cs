using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class PTag :BaseEntitiy
    {

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public IEnumerable<ProtuctTag> ProtuctTags { get; set; }
    }
}
