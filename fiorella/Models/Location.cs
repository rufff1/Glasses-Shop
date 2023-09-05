using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Location :BaseEntitiy
    {
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(150)]
        public string Adress { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string MapLink { get; set; }
    }
}
