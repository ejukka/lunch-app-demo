using System.Collections.Generic;
using System.Text.Encodings.Web;
using Lunch_app_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lunch_app_demo.Controllers
{
    public class RuproController : Controller
    {
        
        private static readonly IList<CommentModel> comments;

        static RuproController()
        {
            comments = new List<CommentModel>
            {
                new CommentModel
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new CommentModel
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new CommentModel
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                },
            };
        }


        [HttpGet("/")]
        public ViewResult Index()
        {
            return View();
        }
        
        [Route("comments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Comments()
        {
            return Json(comments);
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