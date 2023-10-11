using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Contact :BaseEntitiy
    {
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(50)]
        [Required]
        public string Phone { get; set; }
        [StringLength(150)]
        [Required]
        public string Subject { get; set; }
        [StringLength(maximumLength:1000)]
        [Required]
        public string Message { get; set; }
    }
}
