using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The R.M.",
                    Rating = "PG",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Price = 7.99M,
                    ImageName = "The R.M.",
                    ImagePath = "/images/the_rm.jpg"
                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    Rating = "PG",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = "Biography",
                    Price = 8.99M,
                    ImageName = "The Other Side of Heaven",
                    ImagePath = "/images/the_other_side_of_heaven.jpeg"
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    Rating = "PG",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Price = 9.99M,
                    ImageName = "Meet The Mormons",
                    ImagePath = "/images/meet_the_mormons.jpg"
                },
                new Movie
                {
                    Title = "The Work and the Glory",
                    Rating = "PG",
                    ReleaseDate = DateTime.Parse("2004-11-24"),
                    Genre = "Period Drama",
                    Price = 3.99M,
                    ImageName = "The Work and the Glory",
                    ImagePath = "/images/work_and_the_glory_cover.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}