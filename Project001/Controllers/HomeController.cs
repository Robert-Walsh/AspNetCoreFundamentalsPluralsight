using Microsoft.AspNetCore.Mvc;
using Project001.Models;
using Project001.Services;

namespace Project001.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }
    }
}
