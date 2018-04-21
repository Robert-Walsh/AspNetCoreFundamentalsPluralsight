using Project001.Models;

//We use this type of view model to enforce form data (or any type of POST data for that matter). This stops a malicious user from overposting.
namespace Project001.ViewModels
{
    public class RestaurantEditModel
    {
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
