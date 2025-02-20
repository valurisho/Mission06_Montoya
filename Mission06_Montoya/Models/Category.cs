using System.ComponentModel.DataAnnotations;

namespace Mission06_Montoya.Models;

public class Category
{
    [Key] //need this here to create the key
    [Required] 
    public int CategoryId{get; set;}
    
    [Required] 
    public string CategoryName {get; set;}
}