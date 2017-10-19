using System;
using Lunch_app_demo.Models;
using System.Linq;

namespace Lunch_app_demo.Data
{
    public class DbInitializer
    {
        public static void Initialize(RestaurantContext context)
        {
            context.Database.EnsureCreated();

            if (context.Restaurants.Any())
            {
                return;
            }

            Restaurant restaurant = new Restaurant
            {
                Genre = "Hima safkaa",
                Name = "Oton Soppa",
                Price = (decimal) 13.4,
                ReleaseDate = DateTime.Today,
                points = Restaurant.RuproPoits.Superb
            };

            context.SaveChanges();
        }
    }
}