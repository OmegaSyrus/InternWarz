using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InternWarz.Models.Battles;

namespace InternWarz.Data
{
    public class InternWarzContext : DbContext
    {
        public InternWarzContext (DbContextOptions<InternWarzContext> options)
            : base(options)
        {
        }

        public DbSet<Battle> Battle { get; set; }
    }
}
