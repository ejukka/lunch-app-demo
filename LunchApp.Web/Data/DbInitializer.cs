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
            
            Restaurant rax = new Restaurant
            {
                Genre = "Pizza buffet",
                Name = "Rax",
                Price = (decimal) 10.9,
                ReleaseDate = DateTime.Today,
                points = Restaurant.RuproPoits.OverAndOut
            };
            
            Restaurant naughty = new Restaurant
            {
                Genre = "Burgerii",
                Name = "Naughty Burger",
                Price = (decimal) 12.0,
                ReleaseDate = DateTime.Today,
                points = Restaurant.RuproPoits.Superb
            };
            context.Restaurants.Add(restaurant);
            context.Restaurants.Add(rax);
            context.Restaurants.Add(naughty);

            context.SaveChanges();
        }
    }
}