using Lunch_app_demo.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace LunchApp.Web.Test
{
    [TestFixture]
    public class RuproControllerTest
    {
        
        private readonly RuproController controller;
        
        public RuproControllerTest()
        {
            controller = new RuproController();
        }
        
        [Test]
        public void ShouldReturnIndexPageTypeViewResult()
        {
            IActionResult indexPage = controller.Index();
            Assert.AreEqual(indexPage.GetType().FullName, "Microsoft.AspNetCore.Mvc.ViewResult");
        }
    }
}