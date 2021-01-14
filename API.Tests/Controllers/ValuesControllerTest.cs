using System;
using API;
using API.Controllers;
using API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Xunit;

namespace API.Tests.Controllers
{
    public class PeopleControllerTest
    {
        [Fact]
        public void Get_ShouldReturnPeople()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            List<Person> result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(new Person(), result.ElementAt(0));
            Assert.Equal(new Person(), result.ElementAt(1));
        }

        [Fact]
        public void GetById_ShouldReturnPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            Person result = controller.Get(5);

            // Assert
            Assert.Equal(new Person(), result);
        }

        [Fact]
        public void Post_ShouldReturnPeopleWithNewPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            List<Person> result = controller.Post(new Person { ID = 4, FirstName="Ruslan", LastName="Sok" });

            // Assert
            Assert.Equal(new List<Person>(), result);
        }


        [Fact]
        public void Delete_ShouldReturnPeopleWithoutDeletedPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController();

            // Act
            List<Person> result = controller.Delete(5);

            // Assert
            Assert.Equal(new List<Person>(), result);
        }
    }
}
