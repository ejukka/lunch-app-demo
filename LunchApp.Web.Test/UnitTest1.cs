using Lunch_app_demo.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace LunchApp.Web.Test
{
    [TestFixture]
    public class UnitTest1
    {
        
        private readonly RuproController controller;
        
        public UnitTest1()
        {
            controller = new RuproController();
        }
        
        [Test]
        public void Test1()
        {
            IActionResult about = controller.Index();
            Assert.AreEqual(about.GetType().FullName, "Microsoft.AspNetCore.Mvc.ViewResult");
        }
    }
}