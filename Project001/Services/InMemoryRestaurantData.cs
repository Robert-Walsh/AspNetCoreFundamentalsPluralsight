using Project001.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project001.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>         
            {
                new Restaurant{ Id = 1, Name = "Rob's Pizza Place", Cuisine=CuisineType.Italian},
                new Restaurant{ Id = 2, Name = "Temple of Camden", Cuisine=CuisineType.Vegan},
                new Restaurant{ Id = 3, Name = "Pitta Party", Cuisine=CuisineType.Vegan}
            };
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);

            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.Find(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
