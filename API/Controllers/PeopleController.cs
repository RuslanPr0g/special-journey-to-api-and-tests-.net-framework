using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    /// <summary>
    /// Information about people.
    /// </summary>
    public class PeopleController : ApiController
    {
        private readonly List<Person> _people;

        /// <summary>
        /// empty contrictor
        /// </summary>
        public PeopleController()
        {
            _people = new List<Person>
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
        }; 
        }

        /// <summary>
        /// constructor to initialize people
        /// </summary>
        /// <param name="people"></param>
        public PeopleController(List<Person> people)
        {
            _people = people;
        }

        /// <summary>
        /// Get all first names of people
        /// </summary>
        /// <returns>first names as list of string</returns>
        [Route("api/people/firstnames")]
        [HttpGet]
        public List<string> FirstNames()
        {
            return _people.Select(p => p.FirstName).ToList();
        }

        /// <summary>
        /// Get particular first name of person by id
        /// </summary>
        /// <param name="id">id of person</param>
        /// <returns>first name as string</returns>
        [Route("api/people/firstnames/{id}")]
        [HttpGet]
        public string FirstNames(int id)
        {
            return _people.Where(p => p.ID == id).FirstOrDefault().FirstName;
        }

        /// <summary>
        /// Get all the people
        /// </summary>
        /// <returns>list of people</returns>
        // GET: api/People
        public List<Person> Get()
        {
            return _people;
        }

        /// <summary>
        /// get person by id
        /// </summary>
        /// <param name="id">id of person</param>
        /// <returns>person</returns>
        // GET: api/People/5
        public Person Get(int id)
        {
            return _people.Where(p => p.ID == id).FirstOrDefault();
        }

        /// <summary>
        /// add person
        /// </summary>
        /// <param name="person">person to add</param>
        // POST: api/People
        public List<Person> Post(Person person)
        {
            _people.Add(person);

            return _people;
        }

        /// <summary>
        /// delete person by id
        /// </summary>
        /// <param name="id">id of person</param>
        // DELETE: api/People/5
        public List<Person> Delete(int id)
        {
            _people.RemoveAt(id);

            return _people;
        }
    }
}