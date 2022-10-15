using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Data
{
    public class CodeFirstApproachContext : DbContext
    {
        public CodeFirstApproachContext (DbContextOptions<CodeFirstApproachContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstApproach.Models.Trainee> Trainee { get; set; } = default!;
    }
}
