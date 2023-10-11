using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.Models
{
    public class Product :BaseEntitiy
    {
        
        [StringLength(200)]
        [Required]

        public string Name { get; set; }

        [StringLength(20)]
        [Required]
        [DataType("money")]
        public double Price { get; set; }
        [Display(Name ="Endirimli Qiymeti")]
        [StringLength(20)]
        public double DiscountedPrice { get; set; }
        [StringLength(1000)]
        [Required]
        public string Description { get; set; }
        [StringLength(20)]
        public string SizeWight { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(50)]
        public string Sku { get; set; }
        [StringLength(50)]
        public DateTime Date { get; set; }
        [StringLength(50)]
        public string Life { get; set; }
        [StringLength(50)]
        public string frame { get; set; }

        public bool IsTopSelling { get; set; }
        public bool IsTrending { get; set; }




        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<ProductColor> ProductColors { get; set; }
        public IEnumerable<ProtuctTag> ProtuctTags { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }






    }
}
