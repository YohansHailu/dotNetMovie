using Microsoft.AspNetCore.Identity;
namespace Movies.Models;
public class User : IdentityUser
{
    public string? Name { get; set; }
}
