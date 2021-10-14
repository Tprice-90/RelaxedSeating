using System;
using System.ComponentModel.DataAnnotations;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace RelaxedSeating.Models
{
    //Setting and getting the properties for the Chair Model
    public class Chair
    {
        public int ChairId { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateMade { get; set; }
        public decimal Price { get; set; }

    }
}
