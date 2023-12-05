using Microsoft.AspNetCore.Identity;
namespace Movies.Models;
public class User : IdentityUser
{
    public string? Name { get; set; }
    public string? Password { get; set; }
    public string? Role { get; set; }
}
