using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using CollectionWebApp.Models;


namespace CollectionWebApp.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; } = null!;
    }
}
