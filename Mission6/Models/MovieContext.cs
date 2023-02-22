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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName= "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }

                );

            mb.Entity<ApplicationResponse>().HasData(

                // SEED DATA INTO THE DATABASE

                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
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
                   CategoryID = 2,
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
                    CategoryID = 1,
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
