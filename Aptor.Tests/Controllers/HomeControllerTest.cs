using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aptor.Controllers;

namespace Aptor.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("System do zarządzania zamówieniami.", result.ViewBag.Message);
        }
    }
}
