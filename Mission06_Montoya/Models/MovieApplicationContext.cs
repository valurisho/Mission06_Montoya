using Microsoft.EntityFrameworkCore;

namespace Mission06_Montoya.Models;

public class FilmContext : DbContext
{
    public FilmContext(DbContextOptions<FilmContext> options) : base(options)
    {
        
    }
    public DbSet<Movie> Movies { get; set; } //table
    //Aplication type comes from the Models - Application.cs
    public DbSet<Category> Categories { get; set; } //table
    
}
