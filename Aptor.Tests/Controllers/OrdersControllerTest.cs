using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aptor.Controllers;

namespace Aptor.Tests.Controllers
{
    [TestClass]
    public class OrdersControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            OrdersController controller = new OrdersController();

            // Act
            ViewResult result = controller.Index(null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            OrdersController controller = new OrdersController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
