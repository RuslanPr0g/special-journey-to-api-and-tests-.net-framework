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
        private List<Person> people = new List<Person>
        {
             new Person
             {
                 ID = 0,
                 FirstName = "John",
                 LastName = "Smith"
             },
             new Person
             {
                 ID = 1,
                 FirstName = "Dmitriy",
                 LastName = "Amerados"
             },
             new Person
             {
                 ID = 2,
                 FirstName = "William",
                 LastName = "Shakespear"
             },
             new Person
             {
                 ID = 3,
                 FirstName = "John",
                 LastName = "Williamed"
             },
             new Person
             {
                 ID = 4,
                 FirstName = "Will",
                 LastName = "Smith"
             },
        };

        [Fact]
        public void Get_ShouldReturnPeople()
        {
            // Arrange
            PeopleController controller = new PeopleController(people);

            // Act
            List<Person> result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(people.Count(), result.Count());
            Assert.Equal(people.ElementAt(0), result.ElementAt(0));
            Assert.Equal(people.ElementAt(1), result.ElementAt(1));
            Assert.Equal(people.ElementAt(2), result.ElementAt(2));
            Assert.Equal(people.ElementAt(3), result.ElementAt(3));
        }

        [Fact]
        public void Get_ShouldT()
        {
            // Arrange
            PeopleController controller = new PeopleController(people);

            // Act
            List<Person> result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(people.Count(), result.Count());
            Assert.Equal(people.ElementAt(0), result.ElementAt(0));
            Assert.Equal(people.ElementAt(1), result.ElementAt(1));
            Assert.Equal(people.ElementAt(2), result.ElementAt(2));
            Assert.Equal(people.ElementAt(3), result.ElementAt(3));
        }

        [Fact]
        public void GetById_ShouldReturnPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController(people);
            int index = 2;

            // Act
            Person result = controller.Get(index);

            // Assert
            Assert.Equal(people.ElementAt(index), result);
        }

        [Fact]
        public void Post_ShouldReturnPeopleWithNewPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController(people);
            Person person = new Person { ID = 4, FirstName = "Ruslan", LastName = "Sok" };

            // Act
            List<Person> result = controller.Post(person);
            people.Add(person);

            // Assert
            Assert.Equal(people, result);
        }


        [Fact]
        public void Delete_ShouldReturnPeopleWithoutDeletedPerson()
        {
            // Arrange
            PeopleController controller = new PeopleController(people);
            int index = 1;

            // Act
            List<Person> result = controller.Delete(index);
            people.RemoveAt(index);

            // Assert
            Assert.Equal(people, result);
        }
    }
}
