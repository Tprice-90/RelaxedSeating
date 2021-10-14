//SeedData will load entries into the database when the database is empty
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RelaxedSeating.Data;
using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;

namespace RelaxedSeating.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RelaxedSeatingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RelaxedSeatingContext>>()))
            {
                //Checking for any Chair entries in database
                if(context.Chair.Any())
                {
                    return;
                }

                context.Chair.AddRange(
                    new Chair
                    {
                        Name = "Seat Patches",
                        Material = "Wood and Cloth",
                        DateMade = DateTime.Parse("1990-01-01"),
                        //Category = "General",
                        Price = 24.99M,
                        Rating = 4
                    },
                    new Chair
                    {
                        Name = "Blue Patio",
                        Material = "Metal and Mesh",
                        DateMade = DateTime.Parse("2001-4-24"),
                        //Category = "Outdoor",
                        Price = 40.00M,
                        Rating = 5
                    },
                    new Chair
                    {
                        Name = "Classic Dining",
                        Material = "Wood and Cloth",
                        DateMade = DateTime.Parse("1980-11-04"),
                        //Category = "Dinning",
                        Price = 55.99M,
                        Rating = 3
                    },
                    new Chair
                    {
                        Name = "Modern Dining",
                        Material = "Wood",
                        DateMade = DateTime.Parse("1995-05-13"),
                        //Category = "Dining",
                        Price = 33.99M,
                        Rating = 2
                    },
                    new Chair
                    {
                        Name = "Classic Desk",
                        Material = "Wood",
                        DateMade = DateTime.Parse("1982-09-22"),
                        //Category = "Office",
                        Price = 45.99M,
                        Rating = 3
                    },
                    new Chair
                    {
                        Name = "Paw Patrol Child Chair",
                        Material = "Aluminum and Canvas",
                        DateMade = DateTime.Parse("2014-03-22"),
                        //Category = "Childrens",
                        Price = 15.99M,
                        Rating = 4
                    },
                    new Chair
                    {
                        Name = "Monkey Child Chair",
                        Material = "Metal and Canvas",
                        DateMade = DateTime.Parse("2008-06-14"),
                        //Category = "Childrens",
                        Price = 14.99M,
                        Rating = 5
                    },
                    new Chair
                    {
                        Name = "Dora The Explorer Chair",
                        Material = "Wood",
                        DateMade = DateTime.Parse("2007-01-17"),
                        //Category = "Childrens",
                        Price = 12.99M,
                        Rating = 2
                    },
                    new Chair
                    {
                        Name = "Lazy Recliner",
                        Material = "Wood and Cloth",
                        DateMade = DateTime.Parse("1990-11-03"),
                        //Category = "General",
                        Price = 45.99M,
                        Rating = 5
                    },
                    new Chair
                    {
                        Name = "Star Child Chair",
                        Material = "Wood",
                        DateMade = DateTime.Parse("1996-02-12"),
                        //Category = "Childrens",
                        Price = 9.99M,
                        Rating = 3
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
