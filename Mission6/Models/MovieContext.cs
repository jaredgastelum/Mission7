using System;
using Microsoft.EntityFrameworkCore;
using Mission6.Models;

namespace Mission6.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                // SEED DATA INTO THE DATABASE

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Harry Potter and the Deathly Hallows – Part 2",
                    Year = 2011,
                    Director = "David Yates",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },

               new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Comedy",
                    Title = "Pink Panther",
                    Year = 2006,
                    Director = "Shawn Levy",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },

              new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                }

                );
        }
    }
}
