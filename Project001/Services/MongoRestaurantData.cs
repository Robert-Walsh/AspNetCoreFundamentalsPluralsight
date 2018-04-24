using System;
using System.Collections.Generic;
using Project001.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Project001.Services
{
    public class MongoRestaurantData : IRestaurantData
    {
        public Restaurant Add(Restaurant newRestaurant)
        {

            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            IMongoDatabase database = client.GetDatabase("restaurantdata");
            var collection = database.GetCollection<BsonDocument>("restaurants");

            var document = new BsonDocument
            {
                {"name", BsonValue.Create(newRestaurant.Name)},
                {"cuisine_type", BsonValue.Create(newRestaurant.Cuisine)}
            };

            collection.InsertOneAsync(document);

            return newRestaurant;

        }

        public Restaurant Get(int id)
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            IMongoDatabase database = client.GetDatabase("RestaurantData");
            var collection = database.GetCollection<BsonDocument>("Restaurants");



            return null;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            IMongoDatabase database = client.GetDatabase("RestaurantData");
            var collection = database.GetCollection<BsonDocument>("Restaurants");


            var response = collection.FindAsync();
        }
    }
}
