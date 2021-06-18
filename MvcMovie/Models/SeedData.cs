using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                //The RM, Other Side of Heaven, and Meet the Mormons
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "G",
                        Price = 7.99M,
                        Image = "the_rm.jpg"
                    },
                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Romantic",
                        Rating = "G",
                        Price = 10.99M,
                        Image = "other_side_of_heaven.jpg"
                    },
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "G",
                        Price = 15.99M,
                        Image = "meet_the_mormons.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}