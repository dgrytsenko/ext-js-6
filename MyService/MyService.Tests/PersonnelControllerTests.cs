using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyService.Controllers;
using MyService.Models;

namespace MyService.Tests
{
    [TestClass]
    public class PersonnelControllerTests
    {
        [TestMethod]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var controller = new PersonellController();

            var result = controller.GetAllPersonnel();
            Assert.IsTrue(result.Any());
        }
    }
}
