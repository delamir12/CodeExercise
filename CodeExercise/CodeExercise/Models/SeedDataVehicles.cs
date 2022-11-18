using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeExercise.Data;
using System;
using System.Linq;

namespace CodeExercise.Models
{
    public static class SeedDataVehicles
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodeExerciseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CodeExerciseContext>>()))
            {
                // Look for any movies.
//               if (context.Vehicles.Any())
//               {
//                   return;   // DB has been seeded
//               }
                context.Vehicles.AddRange(
                    new Vehicles
                    {
                        Brand = "Paco",
                        Vin = "Fernandes",
                        Color = "b",
                        Year = "1998",
                        OwnerId = 1
                    },
                    new Vehicles
                    {
                        Brand = "VW",
                        Vin = "2346235",
                        Color = "b",
                        Year = "1998",
                        OwnerId = 2
                    },
                    new Vehicles
                    {
                        Brand = "BMW",
                        Vin = "436256",
                        Color = "s",
                        Year = "1998",
                        OwnerId = 3
                    },
                    new Vehicles
                    {
                        Brand = "MB",
                        Vin = "634745",
                        Color = "c",
                        Year = "2022",
                        OwnerId = 4
                    }
                );
 //               context.SaveChanges();
            }
        }
    }
}


