using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RezorPagesApp.Models;

namespace RezorPagesApp.Data
{
    public class RezorPagesAppContext : DbContext
    {
        public RezorPagesAppContext (DbContextOptions<RezorPagesAppContext> options)
            : base(options)
        {
        }

        public DbSet<RezorPagesApp.Models.Movie> Movie { get; set; } = default!;
    }
}
