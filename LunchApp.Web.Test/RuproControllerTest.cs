using Lunch_app_demo.Controllers;
using Lunch_app_demo.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace LunchApp.Web.Test
{
    [TestFixture]
    public class RuproControllerTest
    {
        
        private readonly RuproController controller;
        private readonly RestaurantContext context;
        
        public RuproControllerTest(RestaurantContext context)
        {
            this.context = context;
            controller = new RuproController(context);
        }
        
        [Test]
        public void ShouldReturnIndexPageTypeViewResult()
        {
            IActionResult indexPage = controller.Index();
            Assert.AreEqual(indexPage.GetType().FullName, "Microsoft.AspNetCore.Mvc.ViewResult");
        }
    }
}