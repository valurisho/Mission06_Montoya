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
    
    public IActionResult Collection()
    { 
        var movies = _context.Movies
            .Include(x => x.Category)
            .OrderBy(x => x.Title).ToList();
        return View(movies); //return the collection view but takes the movies list with it
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies
            .Single(x=>x.MovieId == id); //find the id based on the id we passed
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName).ToList();
        return View("EnterMovie", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Update(updatedInfo);
        _context.SaveChanges();

        return RedirectToAction("Collection");
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id); //using single to only have 1 record
        return View(recordToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Movie recordToDelete)
    {
        _context.Movies.Remove(recordToDelete);
        _context.SaveChanges();
        return RedirectToAction("Collection");
    }
    

}