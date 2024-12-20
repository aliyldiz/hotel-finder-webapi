using System.ComponentModel.DataAnnotations;

namespace HotelFinder.Entities;

public class Hotel
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string City { get; set; }
}