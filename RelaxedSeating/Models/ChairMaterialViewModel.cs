//Chair Material View Model will allow searching chairs by material instead of Name
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Concurrent;

namespace RelaxedSeating.Models
{
    public class ChairMaterialViewModel
    {
        public List<Chair> Chairs { get; set; }
        public SelectList Materials { get; set; }
        public string ChairMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
