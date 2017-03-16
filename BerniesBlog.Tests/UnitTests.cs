using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using BerniesBlog.WebUI.Controllers;
using BerniesBlog.WebUI.Infrastructure.Abstract;
using BerniesBlog.WebUI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BerniesBlog.Tests
{
    class UnitTests
    {
        [TestClass]
        public class AdminSecurityTests
        {
            [TestMethod]
            public void Can_Login_With_Credentials()
            {
                // Arrange - create a mock authentication provider
                Mock<IAuthProvider> mock = new Mock<IAuthProvider>();
                mock.Setup(m => m.Authenticate("admin", "secret")).Returns(true);

                //Arrange - create the view model
                LoginViewModel model = new LoginViewModel
                {
                    username = "admin",
                    password = "secret"
                };

                // Arrange - create the conroller
                AccountController controller = new AccountController(mock.Object);

                // Act - authenticate using valid credentials
                ActionResult result = controller.Login(model, "/MyUrl");

                //Assert

                Assert.IsInstanceOfType(result, typeof(RedirectResult));
                Assert.AreEqual("/MyUrl", ((RedirectResult)result).Url);
            }
        }
    }
}
