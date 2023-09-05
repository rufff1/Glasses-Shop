﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Category :BaseEntitiy
    {
        [StringLength(100)]
        [Required]
        public string Name { get; set; }


        public IEnumerable<Blog> Blogs { get; set; }
    }
}