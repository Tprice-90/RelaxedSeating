using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace RelaxedSeating.Controllers
{
    public class RelaxeSeatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
