using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieCrud.Controllers.Dto;
using Movies.Models;

namespace MovieCrud.Controllers;

[Route("[controller]")]
public class UserController : Controller
{
    private readonly UserDbContext _userDb;
    private readonly UserManager<User> _userManager;
    public UserController(UserDbContext userDb, UserManager<User> userManager)
    {
        this._userDb = userDb;
        this._userManager = userManager;
    }

    [HttpGet("all")]
    public IActionResult GetAllUsers()
    {
        return Ok(_userManager.Users.ToList());
    }

    public async Task<IActionResult> Login()
    {
        
    }
    
    
    

    [HttpPost("add")]
    public async Task<IActionResult> AddUser([FromBody] RegisterDto userDot)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return BadRequest(errors);
        }

        var existingEmail = await  _userManager.FindByEmailAsync(userDot.email);
        if (existingEmail != null)
        {
            ModelState.AddModelError("Email", "Email already exits");
        }

        var existingUserName = await _userManager.FindByNameAsync(userDot.userName);
        if (existingEmail != null)
        {
            ModelState.AddModelError("user-name", "user-name already exits");
        }

        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return BadRequest(errors);
        }
        
    
        var user = new User
        {
            Email = userDot.email,
            UserName= userDot.userName,
            Name = userDot.name,
        };

        var res = await _userManager.CreateAsync(user, userDot.password);
        if (!res.Succeeded)
        {
            return BadRequest(res.Errors.Select((e => e.Description)));
        }
        return Ok(res);
    }
}