using Project001.Models;
using System.Collections.Generic;

namespace Project001.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
}
