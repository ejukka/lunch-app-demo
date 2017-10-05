using Lunch_app_demo.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace LunchApp.Web.Test
{
    [TestFixture]
    public class UnitTest1
    {
        
        private readonly HomeController controller;
        
        public UnitTest1()
        {
            controller = new HomeController();
        }
        
        [Test]
        public void Test1()
        {
            IActionResult about = controller.About();
            Assert.AreEqual(about.GetType().FullName, "Microsoft.AspNetCore.Mvc.ViewResult");
        }
    }
}