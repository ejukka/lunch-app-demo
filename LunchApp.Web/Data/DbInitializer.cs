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

            CommentModel firstComment = new CommentModel
            {
                Id = 1,
                Author = "Daniel Lo Nigro",
                Text = "Hello ReactJS.NET World!"
            };
            CommentModel secondComment = new CommentModel
            {
                Id = 2,
                Author = "Pete Hunt",
                Text = "This is one comment"
            };
            CommentModel thirdComment = new CommentModel
            {
                Id = 3,
                Author = "Jordan Walke",
                Text = "This is *another* comment"
            };
            
            context.Comments.Add(firstComment);
            context.Comments.Add(secondComment);
            context.Comments.Add(thirdComment);

            context.SaveChanges();
        }
    }
}