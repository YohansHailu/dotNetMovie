using System.ComponentModel.DataAnnotations.Schema;
namespace Movies.Models;
public class Cenima
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

}
