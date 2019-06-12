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
        public void GetAllProducts_ShouldReturnAllPersons()
        {
            var controller = new PersonellController();

            var result = controller.GetAllPersonnel();
            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public void GetAllProducts_ShouldReturnOnePerson()
        {
            var controller = new PersonellController();

            var result = controller.GetPersonnelById(new Guid("e7d486af-ee6a-447d-86f0-a7ebd30fe296"));
            Assert.IsNotNull(result);
        }
    }
}
