using System.Threading.Tasks;
using Lunch_app_demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lunch_app_demo.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly RestaurantContext context;

        public RestaurantController(RestaurantContext context)
        {
            this.context = context;
        }

        [HttpGet("restaurants")]
        public async Task<IActionResult> Index()
        {
            return View(await context.Restaurants.ToListAsync());
        }
        
        public IActionResult Delete()
        {
            throw new System.NotImplementedException();
        }
        
        public IActionResult Edit()
        {
            throw new System.NotImplementedException();
        }
        
        public IActionResult Details()
        {
            throw new System.NotImplementedException();
        }
        
        public IActionResult Create()
        {
            throw new System.NotImplementedException();
        }
    }
}