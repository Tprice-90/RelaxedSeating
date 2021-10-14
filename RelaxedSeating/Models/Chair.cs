using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace RelaxedSeating.Models
{
    //Setting and getting the properties for the Chair Model
    public class Chair
    {
        public int ChairId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(40)]
        public string Material { get; set; }
        [Display(Name = "Date Made")]
        [DataType(DataType.Date)]
        public DateTime DateMade { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
    }
}
