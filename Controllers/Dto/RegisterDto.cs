using System.ComponentModel.DataAnnotations;

namespace MovieCrud.Controllers.Dto;

public class RegisterDto
{
    public string name { get; set; }
    [Required]
    public string userName { get; set; }
    [Required]
    public string email { get; set; }
    [Required]
    public string password { get; set; }
    
}