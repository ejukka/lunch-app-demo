﻿using Microsoft.EntityFrameworkCore;

namespace Lunch_app_demo.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext (DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Restaurant> Restaurants { get; set; }
    }
}