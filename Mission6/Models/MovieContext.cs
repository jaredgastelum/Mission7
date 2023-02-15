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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //mb.Entity<ApplicationResponse>().HasData(

            //    new ApplicationResponse
            //    {
            //        MovieID: 1,
            //        Category: "Action/Adventure",
            //        Title: "Harry Potter and the Deathly Hallows – Part 2",
            //        Year: ,
            //        Director: ,
            //        Rating: ,
            //        Edited: ,
            //        LentTo: ,
            //        Notes: ,
            //    }


            //    );
        }
    }
}
