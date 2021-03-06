﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HaraNoHara.Web;
using HaraNoHara.Web.Controllers;

namespace HaraNoHara.Web.Tests.Controllers
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
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Results()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Results() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
