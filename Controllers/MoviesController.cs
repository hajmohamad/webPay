using Microsoft.AspNetCore.Mvc;
using webPay.Models;
using webPay.Models.PageAttribute;

namespace webPay.Controllers;

public class MoviesController : Controller
{
    private readonly WebPayDbContext _dbContext;

    public MoviesController()
    {
        _dbContext = new WebPayDbContext();
    }
    // GET
    public IActionResult Index()
    {
        var movies = _dbContext.Movies.ToList();
        return View(movies);
    }
    public IActionResult MovieForm()
    {
        var movieFormViewModel = new MovieFormViewModel();
        return View(movieFormViewModel);
    }
    [HttpPost]
    public IActionResult Save(Movie movie)
    {
        if (movie.Id == 0)
        {
            _dbContext.Movies.Add(movie);
        }
        else
        
        {
            var movieInDb = _dbContext.Movies.Find(movie.Id);
            if (movieInDb == null)
            {
                return NotFound();
            }
            movieInDb.Name = movie.Name;
            movieInDb.NumberInStock = movie.NumberInStock;
            movieInDb.Genre = movie.Genre;
            
        }

        _dbContext.SaveChanges();
        return RedirectToAction("Index");
        
        
        
    }

    public IActionResult New()
    {

        return View("MovieForm", new MovieFormViewModel());

    }

    public IActionResult Edit(int id)
    {
        var movies = _dbContext.Movies.Find(id);
        if (movies == null)
        {
            return NotFound();
        }
        return View("MovieForm", new MovieFormViewModel
        {
            Movie = movies
        });
    }
}