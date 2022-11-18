using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeExercise.Models;

namespace CodeExercise.Data
{
    public class CodeExerciseContext : DbContext
    {
        public CodeExerciseContext (DbContextOptions<CodeExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<CodeExercise.Models.Owners> Owners { get; set; } = default!;

        public DbSet<CodeExercise.Models.Vehicles> Vehicles { get; set; }
    }
}
