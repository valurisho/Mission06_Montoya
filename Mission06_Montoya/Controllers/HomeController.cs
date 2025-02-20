using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Montoya.Models;

namespace Mission06_Montoya.Controllers;

public class HomeController : Controller
{
    private FilmContext _context;
    
    public HomeController(FilmContext temporary) //constructor
    {
        _context = temporary;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MeetJoel()
    {
        return View();
    }
    [HttpGet]
    public IActionResult EnterMovie()
    {
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName).ToList();
        return View();
    }
    [HttpPost]
    public IActionResult EnterMovie(Movie response)
    {
        _context.Movies.Add(response); // add record to database
        _context.SaveChanges(); //save the changes on the database
        return View("Confirmation", response); //brings up the confirmation view
    }

    [HttpGet]
    public IActionResult Collection()
    {
        var movies = _context.Movies
            .Include(x => x.Category)
            .OrderBy(x => x.Title).ToList();
        return View(movies); //return the collection view but takes the movies list with it
    }
    
    
    
}