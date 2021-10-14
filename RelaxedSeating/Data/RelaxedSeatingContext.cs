using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelaxedSeating.Models;

namespace RelaxedSeating.Data
{
    public class RelaxedSeatingContext : DbContext
    {
        public RelaxedSeatingContext (DbContextOptions<RelaxedSeatingContext> options)
            : base(options)
        {
        }

        public DbSet<Chair> Chair { get; set; }
    }
}
