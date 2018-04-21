using Project001.Models;
using System.ComponentModel.DataAnnotations;

//We use this type of view model to enforce form data (or any type of POST data for that matter). This stops a malicious user from overposting.
namespace Project001.ViewModels
{
    public class RestaurantEditModel
    {
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
