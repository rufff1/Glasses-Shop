﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class OurPerformance :BaseEntitiy
    {
        [StringLength(150)]
        [Required]
        public string Image { get; set; }
        [StringLength(150)]
        [Required]
        public string Title { get; set; }
        [StringLength(1000)]
        [Required]
        public string Descriptoion1 { get; set; }
        [StringLength(1000)]
        [Required]
        public string Descriptoion2 { get; set; }

    }
}
