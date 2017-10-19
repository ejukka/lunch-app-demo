using System;

namespace Lunch_app_demo.Models
{
    public class Restaurant
    {
        
        public enum RuproPoits
        {
            Superb, Semi_Ok, Ok, NotGood, Skull, SecondWarning, OverAndOut
        }
        
        public Restaurant()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public RuproPoits points { get; set; }
    }
}