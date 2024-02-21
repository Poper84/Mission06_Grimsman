using Microsoft.EntityFrameworkCore;

namespace Mission_6.Models
{
    public class MovieApplicationContext : DbContext 
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
