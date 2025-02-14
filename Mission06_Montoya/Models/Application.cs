using System.ComponentModel.DataAnnotations;

namespace Mission06_Montoya.Models;

public class Application
{
    
    [Key] //need this here to create the key
    [Required] 
    public int FilmId{get; set;}
    public string Category {get; set;}
    public string Title {get; set;}
    public string Director {get; set;}
    public int Year {get; set;}
    public string Rating {get; set;}
    public bool? Edited { get; set; } = false; //defaulting to false
    public string? Notes {get; set;}
    public string? LendTo {get; set;}
    
}
