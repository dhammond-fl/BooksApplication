using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BooksApplication.Controllers;

namespace BooksApplication.Tests.Controllers
{
    [TestClass]
    public class BooksControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            BooksController controller = new BooksController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

       
    }
}
