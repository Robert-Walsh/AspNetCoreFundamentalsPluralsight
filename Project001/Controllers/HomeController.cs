using Microsoft.AspNetCore.Mvc;
using Project001.Models;

namespace Project001.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant {
                Id = 1, Name = "Rob's Pizza Place"
            };

            return View(model);
        }
    }
}
