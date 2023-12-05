using Microsoft.EntityFrameworkCore;
using Movies.Models;
public class MovieDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=movie.db");
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cenima> Cenimas { get; set; }
}
