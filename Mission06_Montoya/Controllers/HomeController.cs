using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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
        return View();
    }
    [HttpPost]
    public IActionResult EnterMovie(Application response)
    {
        _context.Film.Add(response); // add record to database
        _context.SaveChanges(); //save the changes on the database
        return View("Confirmation", response); //brings up the confirmation view
    }
    
    
}