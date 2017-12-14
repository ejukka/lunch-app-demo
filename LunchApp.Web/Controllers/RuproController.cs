using System.Linq;
using System.Text.Encodings.Web;
using Lunch_app_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lunch_app_demo.Controllers
{
    public class RuproController : Controller
    {
        private readonly RestaurantContext context;
        
        public RuproController(RestaurantContext context)
        {
            this.context = context;
        }
        
        [HttpGet("/")]
        public ViewResult Index()
        {
            return View();
        }

        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public JsonResult Comments()
        {
            return Json(context.Comments.ToList());
        }

        [HttpGet("/test")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ViewResult test()
        {
            return View();
        }

        [HttpGet("rupro/welcome")]
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        [HttpGet("rupro/test")]
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}