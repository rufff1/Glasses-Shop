using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class WelcomeNest :BaseEntitiy
    {

        [StringLength(225)]
        [Required]
        public string Image { get; set; }

        [StringLength(1000)]
        public string Description1 { get; set; }
        [StringLength(1000)]
        public string Description2 { get; set; }
    }
}
