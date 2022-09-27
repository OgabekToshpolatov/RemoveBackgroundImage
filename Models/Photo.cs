using System.ComponentModel.DataAnnotations;

namespace RemoveBg.Models;

public class Photo
{
    [Required]
    public List<IFormFile>? Images { get; set; }
}