using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeExercise.Data;
using System;
using System.Linq;

namespace CodeExercise.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CodeExerciseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CodeExerciseContext>>()))
            {
                // Look for any movies.
                if (context.Owners.Any())
                {
                    return;   // DB has been seeded
                }
                context.Owners.AddRange(
                    new Owners
                    {
                        FirstName = "Paco",
                        LastName = "Fernandes",
                        DriverLicence = "b"
                    },
                    new Owners
                    {
                        FirstName = "Ivan",
                        LastName = "Fernandes",
                        DriverLicence = "c"
                    },
                    new Owners
                    {
                        FirstName = "Denis",
                        LastName = "Fernandes",
                        DriverLicence = "d"
                    },
                    new Owners
                    {
                        FirstName = "Paco",
                        LastName = "Raban",
                        DriverLicence = "A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}


