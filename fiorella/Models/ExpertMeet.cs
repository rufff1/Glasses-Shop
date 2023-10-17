using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class ExpertMeet :BaseEntitiy
    {
        [StringLength(250)]
        [Required]
        public string Title { get; set; }
        [StringLength(1000)]
        [Required]
        public string Description1 { get; set; }
        [StringLength(1000)]
        public string Description2 { get; set; }
    }
}
