using Microsoft.AspNetCore.Mvc;
using Movies.Models;

namespace MovieApp.Controllers;
[Route("[controller]")]
public class CenimaController : Controller
{
    MovieDbContext movieDb;
    public CenimaController(MovieDbContext movieDb)
    {
        this.movieDb = movieDb;
    }

    [HttpGet("all")]
    public IActionResult getAllCenima()
    {
        return Ok(movieDb.Cenimas.ToList());
    }

    [HttpPost("add")]
    public IActionResult addCenima(Cenima cenima)
    {
        movieDb.Cenimas.Add(cenima);
        movieDb.SaveChanges();
        return Ok(cenima);
    }


}
