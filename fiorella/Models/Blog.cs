using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Blog :BaseEntitiy
    {
        [Required]
        [StringLength(150)]
        public string Image1 { get; set; }
        [Required]
        [StringLength(150)]
        public string MainTitle { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description1 { get; set; }
      
        [StringLength(150)]
        public string Image2 { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
      
        [StringLength(1000)]
        public string Description2 { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }


        //many to many tags
        public IEnumerable<BlogTag> BlogTags { get; set; }
        //one to many category
        public Category Category { get; set; }
        public int BlogId { get; set; }

    }
}
