using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Montoya.Models;

public class Movie
{
    
    [Key] //need this here to create the key
    [Required] 
    public int MovieId{get; set;}
    
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category {get; set;}
    public string Title {get; set;}
    
    [Range(1888, int.MaxValue, ErrorMessage = "The year must be 1888 or later.")]
    public int Year {get; set;}
    public string? Director {get; set;}
    public string? Rating {get; set;}
    public bool Edited { get; set; } = false; //defaulting to false
    
    public bool CopiedToPlex {get; set;}
    public string? Notes {get; set;}
    public string? LentTo {get; set;}
    
}
