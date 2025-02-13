using Microsoft.EntityFrameworkCore;

namespace Mission06_Montoya.Models;

public class FilmContext : DbContext
{
    public FilmContext(DbContextOptions<FilmContext> options) : base(options)
    {
        
    }
    public DbSet<Application> Film { get; set; } //table
    //Aplication type comes from the Models - Application.cs
}
