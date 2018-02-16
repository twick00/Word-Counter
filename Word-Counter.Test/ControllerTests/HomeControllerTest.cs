using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Word_Counter.Controllers;
using Word_Counter.Models;

namespace Word_Counter.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();

            IActionResult indexView = controller.Index();
            ViewResult result = indexView as ViewResult;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}