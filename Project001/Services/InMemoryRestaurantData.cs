using Project001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project001.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id = 1, Name = "Rob's Pizza Place"},
                new Restaurant{ Id = 2, Name = "Temple of Camden"},
                new Restaurant{ Id = 3, Name = "Pitta Party"}
            };
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
