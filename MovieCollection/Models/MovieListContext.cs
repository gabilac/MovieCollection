using System;
using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    //database setup
    public class MovieListContext : DbContext
    {
        public MovieListContext (DbContextOptions<MovieListContext> options) : base (options)
        {

        }

        public DbSet<NewMovie> Movies { get; set; }
    }
}
