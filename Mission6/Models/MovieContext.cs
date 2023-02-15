using System;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }
    }
}
