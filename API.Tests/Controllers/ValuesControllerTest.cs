using API;
using API.Controllers;
using API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace API.Tests.Controllers
{
    [TestClass]
    public class PeopleControllerTest
    {
        [TestMethod]
        public void Get_ShouldReturnPeople()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            List<Person> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById_ShouldReturnPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            Person result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post_ShouldReturnPeopleWithNewPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            List<Person> result = controller.Post(new Person { ID = 4, FirstName="Ruslan", LastName="Sok" });

            // Assert
            Assert.AreEqual("value", result);
        }


        [TestMethod]
        public void Delete_ShouldReturnPeopleWithoutDeletedPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            List<Person> result = controller.Delete(5);

            // Assert
            Assert.AreEqual("value", result);
        }
    }
}
