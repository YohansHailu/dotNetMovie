using System.ComponentModel.DataAnnotations.Schema;
namespace Movies.Models;
public class Movie
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Genre { get; set; }
}
