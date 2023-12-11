using Microsoft.AspNetCore.Mvc;
using Movies.Models;

namespace MovieApp.Controllers;

[Route("[controller]")]
public class MovieController : Controller
{
    MovieDbContext movieDb;
    public MovieController(MovieDbContext movieDb)
    {
        this.movieDb = movieDb;
    }

    [HttpGet("all")]
    public IActionResult getAllMovies()
    {
        return Ok(movieDb.Movies.ToList());
    }

    [HttpPost("add")]
    public IActionResult addMovie(Movie movie)
    {
        movieDb.Movies.Add(movie);
        movieDb.SaveChanges();
        return Ok(movie);
    }
}
