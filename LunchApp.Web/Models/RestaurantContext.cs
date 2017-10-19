using Microsoft.EntityFrameworkCore;

namespace Lunch_app_demo.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("empty");

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}