using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class OurTeam : BaseEntitiy
    {
        
        [StringLength(150)]
        [Required]
        public string Image { get; set; }
        [StringLength(50)]
        [Required]
        public string FullName { get; set; }
        [StringLength(50)]
        [Required]
        public string Position { get; set; }


        public string Fblink { get; set; }
        public string PinttLink { get; set; }
        public string VimeoLink { get; set; }
        public string TwtLink { get; set; }
    }
}
