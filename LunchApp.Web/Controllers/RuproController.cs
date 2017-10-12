using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lunch_app_demo.Controllers
{
    public class RuproController : Controller
    {
     
        [HttpGet("/")]
        public ViewResult Index()
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